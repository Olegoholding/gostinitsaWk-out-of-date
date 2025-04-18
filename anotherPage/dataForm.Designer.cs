namespace gostinitsaWk.anotherPage
{
    partial class dataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.srcBox = new System.Windows.Forms.TextBox();
            this.indLbl = new System.Windows.Forms.Label();
            this.addData = new System.Windows.Forms.Button();
            this.dltData = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.konetsPick = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.nachaloPick = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridNomer = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridFamiliya = new System.Windows.Forms.DataGridView();
            this.srcBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFamiliya)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 70);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(982, 488);
            this.dataGrid.TabIndex = 0;
            // 
            // srcBox
            // 
            this.srcBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.srcBox.Location = new System.Drawing.Point(12, 35);
            this.srcBox.Multiline = true;
            this.srcBox.Name = "srcBox";
            this.srcBox.Size = new System.Drawing.Size(838, 29);
            this.srcBox.TabIndex = 1;
            // 
            // indLbl
            // 
            this.indLbl.AutoSize = true;
            this.indLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.indLbl.Location = new System.Drawing.Point(12, 9);
            this.indLbl.Name = "indLbl";
            this.indLbl.Size = new System.Drawing.Size(202, 25);
            this.indLbl.TabIndex = 2;
            this.indLbl.Text = "Совершить поиск по";
            // 
            // addData
            // 
            this.addData.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addData.Location = new System.Drawing.Point(696, 6);
            this.addData.Name = "addData";
            this.addData.Size = new System.Drawing.Size(146, 28);
            this.addData.TabIndex = 3;
            this.addData.Text = "Внести данные";
            this.addData.UseVisualStyleBackColor = true;
            this.addData.Click += new System.EventHandler(this.addData_Click);
            // 
            // dltData
            // 
            this.dltData.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dltData.Location = new System.Drawing.Point(848, 6);
            this.dltData.Name = "dltData";
            this.dltData.Size = new System.Drawing.Size(146, 28);
            this.dltData.TabIndex = 4;
            this.dltData.Text = "Удалить данные";
            this.dltData.UseVisualStyleBackColor = true;
            this.dltData.Click += new System.EventHandler(this.dltData_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.konetsPick);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.nachaloPick);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridNomer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridFamiliya);
            this.panel1.Location = new System.Drawing.Point(11, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 555);
            this.panel1.TabIndex = 5;
            // 
            // konetsPick
            // 
            this.konetsPick.Location = new System.Drawing.Point(667, 103);
            this.konetsPick.Name = "konetsPick";
            this.konetsPick.Size = new System.Drawing.Size(313, 22);
            this.konetsPick.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(665, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(309, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Выберите дату конца аренды";
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.Location = new System.Drawing.Point(667, 131);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(313, 101);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Внести данные";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // nachaloPick
            // 
            this.nachaloPick.Location = new System.Drawing.Point(667, 30);
            this.nachaloPick.Name = "nachaloPick";
            this.nachaloPick.Size = new System.Drawing.Size(313, 22);
            this.nachaloPick.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(662, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Выберите дату начала аренды";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(331, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Какую комнату арендуют?";
            // 
            // dataGridNomer
            // 
            this.dataGridNomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNomer.Location = new System.Drawing.Point(336, 30);
            this.dataGridNomer.Name = "dataGridNomer";
            this.dataGridNomer.RowHeadersWidth = 51;
            this.dataGridNomer.RowTemplate.Height = 24;
            this.dataGridNomer.Size = new System.Drawing.Size(274, 515);
            this.dataGridNomer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Кто арендует?";
            // 
            // dataGridFamiliya
            // 
            this.dataGridFamiliya.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFamiliya.Location = new System.Drawing.Point(11, 30);
            this.dataGridFamiliya.Name = "dataGridFamiliya";
            this.dataGridFamiliya.RowHeadersWidth = 51;
            this.dataGridFamiliya.RowTemplate.Height = 24;
            this.dataGridFamiliya.Size = new System.Drawing.Size(292, 515);
            this.dataGridFamiliya.TabIndex = 0;
            // 
            // srcBtn
            // 
            this.srcBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.srcBtn.Location = new System.Drawing.Point(848, 36);
            this.srcBtn.Name = "srcBtn";
            this.srcBtn.Size = new System.Drawing.Size(146, 28);
            this.srcBtn.TabIndex = 6;
            this.srcBtn.Text = "Совершить поиск";
            this.srcBtn.UseVisualStyleBackColor = true;
            this.srcBtn.Click += new System.EventHandler(this.srcBtn_Click);
            // 
            // dataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dltData);
            this.Controls.Add(this.addData);
            this.Controls.Add(this.indLbl);
            this.Controls.Add(this.srcBox);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.srcBtn);
            this.Name = "dataForm";
            this.ShowIcon = false;
            this.Text = "Форма с данными";
            this.Load += new System.EventHandler(this.dataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFamiliya)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TextBox srcBox;
        private System.Windows.Forms.Label indLbl;
        private System.Windows.Forms.Button addData;
        private System.Windows.Forms.Button dltData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridFamiliya;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridNomer;
        private System.Windows.Forms.DateTimePicker nachaloPick;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DateTimePicker konetsPick;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button srcBtn;
    }
}