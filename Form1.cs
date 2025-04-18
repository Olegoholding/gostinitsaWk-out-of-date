using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gostinitsaWk
{
    public partial class mainPage : Form
    {
/*
* Microsoft Windows [Version 10.0.22631.4602]
* (c) TO "Олегохолдинг" (TO "Olegoholding") 2025. All rights secure.
* License to use GNU-4.0
* Use, and have fun
*/
        public mainPage()
        {
            InitializeComponent();
        }
        public static string btnName;
        private void postoyalsi_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                btnName = button.Name;
            }
            anotherPage.dataForm transfer = new anotherPage.dataForm();
            transfer.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
