using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gostinitsaWk.anotherPage
{
/*
* Microsoft Windows [Version 10.0.22631.4602]
* (c) TO "Олегохолдинг" (TO "Olegoholding") 2025. All rights secure.
* License to use GNU-4.0
* Use, and have fun
*/
    public partial class dataForm : Form
    {
        public dataForm()
        {
            InitializeComponent();
        }
        Dictionary<string, string> columnNames = new Dictionary<string, string>
        {
            { "Номер", "id" },
            { "Фамилия", "familiya" },
            { "Имя", "imya" },
            { "Должность", "doljnosty" },
            { "Телефон", "telephone" },
            { "ПорядковыйНомер", "nomer" },
            { "ТипНомера", "tipNomera" },
            { "Стоимость", "cost" }
        };

        public class infComponent
        {
            public static string getConnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\radie\\Downloads\\dbSelim.accdb; Persist Security Info=False;";
        }
        private void dataForm_Load(object sender, EventArgs e)
        {
            var lblInfo = new Dictionary<string, string>
            {
                {"rabochie","Совершить поиск по фамилии"},
                {"postoyalsi",@"Совершить поиск по фамилии"},
                {"nomerInfo",@"Совершить поиск по номеру номера"},
                {"journal",@"Соверишть поиск по дате"}
            };
            if (lblInfo.TryGetValue(mainPage.btnName, out string query))
            {
                indLbl.Text = query;
            }
            dataLoad();
        }
        private void dataLoad()
        {
            var tables = new Dictionary<string, string>
            {
                {"rabochie",@"SELECT id AS Номер, imya AS Имя, familiya AS Фамилия, doljnosty AS Должность, telephone AS Телефон 
                            FROM rabochie"},
                {"postoyalsi",@"SELECT id AS Номер, imya AS Имя, familiya AS Фамилия, telephone AS Телефон 
                            FROM postoyalsi"},
                {"nomerInfo",@"SELECT id AS Номер, nomer AS ПорядковыйНомер, tipNomera AS ТипНомера, cost AS Стоимость 
                            FROM nomerInfo"},
                {"journal",@"SELECT journal.id AS Номер, postoyalsi.imya AS Имя, postoyalsi.familiya AS Фамилия, postoyalsi.telephone AS Телефон, journal.dateNachala AS ДатаНачалаАренды, journal.dateKontsa AS ДатаКонцаАренды, nomerInfo.nomer AS ПорядковыйНомерНомера 
                            FROM ((journal
                            LEFT JOIN nomerInfo ON journal.id_nomera = nomerInfo.id)
                            LEFT JOIN postoyalsi ON journal.id_postoyaltsa = postoyalsi.id)"}
            };
            if (tables.TryGetValue(mainPage.btnName, out string query))
            {
                panel1.Hide();
                using (OleDbConnection conn = new OleDbConnection(infComponent.getConnStr))
                {
                    try
                    {
                        conn.Open();
                        using (OleDbCommand command = new OleDbCommand(query, conn))
                        {
                            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGrid.DataSource = dataTable;
                            dataGrid.AutoGenerateColumns = false;
                        }
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.HResult.ToString());
                    }
                }
            }
            else
            {
                panel1.Show();
                string _query = "SELECT id AS Номер, familiya AS Фамилия FROM postoyalsi";
                string __query = "SELECT id AS Номер, nomer AS НомерКомнаты FROM nomerInfo";
                using (OleDbConnection conn = new OleDbConnection(infComponent.getConnStr))
                {
                    try
                    {
                        conn.Open();
                        using (OleDbCommand command = new OleDbCommand(_query, conn))
                        {
                            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridFamiliya.DataSource = dataTable;
                            dataGridFamiliya.AutoGenerateColumns = false;
                        }
                        conn.Close();
                        conn.Open();
                        using (OleDbCommand command = new OleDbCommand(__query, conn))
                        {
                            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridNomer.DataSource = dataTable;
                            dataGridNomer.AutoGenerateColumns = false;
                        }
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.HResult.ToString());
                    }
                }
            }
        }
        private void dataAdd()
        {
            var dataSet = new DataSet();
            var table = (DataTable)dataGrid.DataSource;

            foreach (DataColumn column in table.Columns)
            {
                if (columnNames.TryGetValue(column.ColumnName, out string localizedName))
                {
                    column.ColumnName = localizedName;
                }
            }

            table.TableName = mainPage.btnName;
            dataSet.Tables.Add(table);

            //foreach (DataColumn column in table.Columns) { MessageBox.Show(column.ColumnName); }

            try
            {
                using (var conn = new OleDbConnection(infComponent.getConnStr))
                {
                    var adapter = new OleDbDataAdapter();
                    adapter.SelectCommand = new OleDbCommand($"SELECT * FROM [{mainPage.btnName}]", conn);
                    var builder = new OleDbCommandBuilder(adapter);

                    adapter.InsertCommand = builder.GetInsertCommand();
                    adapter.Update(dataSet, mainPage.btnName);
                }
                dataSet.Reset();
                dataLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }

        }
        private void dltData_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = int.Parse(dataGrid.Rows[dataGrid.CurrentRow.Index].Cells["Номер"].Value.ToString());
                using (OleDbConnection connection = new OleDbConnection(infComponent.getConnStr))
                {
                    string query = $"DELETE FROM {mainPage.btnName} WHERE id = {ID}";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        dataLoad();
                    }
                    catch (Exception ex)
                    {
                        dataLoad();
                        MessageBox.Show($"Ошибка: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }

        }
        private void addData_Click(object sender, EventArgs e)
        {
            dataAdd();
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            string konets = "";
            string nachalo = "";
            konets = konetsPick.Value.ToString();
            nachalo = nachaloPick.Value.ToString();

            int id = int.Parse(dataGridFamiliya.Rows[dataGridFamiliya.CurrentRow.Index].Cells["Номер"].Value.ToString());
            int _id = int.Parse(dataGridNomer.Rows[dataGridNomer.CurrentRow.Index].Cells["Номер"].Value.ToString());

            string query = @"INSERT INTO journal (id_postoyaltsa, dateNachala, dateKontsa, id_nomera) VALUES(@User_id, @Production_id, @prodType_id, @Cost)";
            using (OleDbConnection conn = new OleDbConnection(infComponent.getConnStr))
            {
                conn.Open();
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@User_id", id);
                    cmd.Parameters.AddWithValue("@Production_id", nachalo);
                    cmd.Parameters.AddWithValue("@prodType_id", konets);
                    cmd.Parameters.AddWithValue("@Cost", _id);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show($"{id}, {_id}");
                }
            }
        }
        private void srcBtn_Click(object sender, EventArgs e)
        {
            var tables = new Dictionary<string, string>
            {
                {"rabochie",$@"SELECT id AS Номер, imya AS Имя, familiya AS Фамилия, doljnosty AS Должность, telephone AS Телефон 
                            FROM rabochie
                            WHERE familiya LIKE '{srcBox.Text}%'"},
                {"postoyalsi",$@"SELECT id AS Номер, imya AS Имя, familiya AS Фамилия, telephone AS Телефон 
                            FROM postoyalsi
                            WHERE familiya LIKE '{srcBox.Text}%'"},
                {"nomerInfo",$@"SELECT id AS Номер, nomer AS ПорядковыйНомер, tipNomera AS ТипНомера, cost AS Стоимость 
                            FROM nomerInfo
                            WHERE nomer LIKE '{srcBox.Text}%'"},
                {"journal",$@"SELECT journal.id AS Номер, postoyalsi.imya AS Имя, postoyalsi.familiya AS Фамилия, postoyalsi.telephone AS Телефон, journal.dateNachala AS ДатаНачалаАренды, journal.dateKontsa AS ДатаКонцаАренды, nomerInfo.nomer AS ПорядковыйНомерНомера 
                            FROM ((journal
                            LEFT JOIN nomerInfo ON journal.id_nomera = nomerInfo.id)
                            LEFT JOIN postoyalsi ON journal.id_postoyaltsa = postoyalsi.id)
                            WHERE dateNachala LIKE '{srcBox.Text}%'"}
            };
            if (tables.TryGetValue(mainPage.btnName, out string query))
            {
                panel1.Hide();
                using (OleDbConnection conn = new OleDbConnection(infComponent.getConnStr))
                {
                    try
                    {
                        conn.Open();
                        using (OleDbCommand command = new OleDbCommand(query, conn))
                        {
                            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGrid.DataSource = dataTable;
                            dataGrid.AutoGenerateColumns = false;
                        }
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.HResult.ToString());
                    }
                }
#warning TO "Olehgoholding"
            }
        }
    }
}
