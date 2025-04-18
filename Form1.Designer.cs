namespace gostinitsaWk
{
    partial class mainPage
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.postoyalsi = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.rabochie = new System.Windows.Forms.Button();
            this.journal = new System.Windows.Forms.Button();
            this.nomerInfo = new System.Windows.Forms.Button();
            this.otchet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // postoyalsi
            // 
            this.postoyalsi.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.postoyalsi.Location = new System.Drawing.Point(13, 21);
            this.postoyalsi.Name = "postoyalsi";
            this.postoyalsi.Size = new System.Drawing.Size(411, 85);
            this.postoyalsi.TabIndex = 0;
            this.postoyalsi.Text = "Просмотерть всех постояльцев";
            this.postoyalsi.UseVisualStyleBackColor = true;
            this.postoyalsi.Click += new System.EventHandler(this.postoyalsi_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitBtn.Location = new System.Drawing.Point(13, 461);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(411, 85);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Выйти из приложения";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // rabochie
            // 
            this.rabochie.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rabochie.Location = new System.Drawing.Point(13, 112);
            this.rabochie.Name = "rabochie";
            this.rabochie.Size = new System.Drawing.Size(411, 85);
            this.rabochie.TabIndex = 2;
            this.rabochie.Text = "Просмотерть всех рабочих";
            this.rabochie.UseVisualStyleBackColor = true;
            this.rabochie.Click += new System.EventHandler(this.postoyalsi_Click);
            // 
            // journal
            // 
            this.journal.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.journal.Location = new System.Drawing.Point(13, 294);
            this.journal.Name = "journal";
            this.journal.Size = new System.Drawing.Size(411, 85);
            this.journal.TabIndex = 3;
            this.journal.Text = "Просмотеть журнал";
            this.journal.UseVisualStyleBackColor = true;
            this.journal.Click += new System.EventHandler(this.postoyalsi_Click);
            // 
            // nomerInfo
            // 
            this.nomerInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nomerInfo.Location = new System.Drawing.Point(13, 203);
            this.nomerInfo.Name = "nomerInfo";
            this.nomerInfo.Size = new System.Drawing.Size(411, 85);
            this.nomerInfo.TabIndex = 4;
            this.nomerInfo.Text = "Просмотерть все номера";
            this.nomerInfo.UseVisualStyleBackColor = true;
            this.nomerInfo.Click += new System.EventHandler(this.postoyalsi_Click);
            // 
            // otchet
            // 
            this.otchet.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.otchet.Location = new System.Drawing.Point(13, 406);
            this.otchet.Name = "otchet";
            this.otchet.Size = new System.Drawing.Size(411, 49);
            this.otchet.TabIndex = 5;
            this.otchet.Text = "Добавить отчёт в журнал...";
            this.otchet.UseVisualStyleBackColor = true;
            this.otchet.Click += new System.EventHandler(this.postoyalsi_Click);
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 553);
            this.Controls.Add(this.otchet);
            this.Controls.Add(this.nomerInfo);
            this.Controls.Add(this.journal);
            this.Controls.Add(this.rabochie);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.postoyalsi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainPage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Главная форма";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button postoyalsi;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button rabochie;
        private System.Windows.Forms.Button journal;
        private System.Windows.Forms.Button nomerInfo;
        private System.Windows.Forms.Button otchet;
    }
}

