
namespace KodEANBelibe
{
    partial class Bazadanych
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bazadanych));
            this.User = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.DBInsertName = new System.Windows.Forms.TextBox();
            this.IPDB = new System.Windows.Forms.TextBox();
            this.OldEANText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DBSaveButton = new System.Windows.Forms.Button();
            this.DBInsertTable = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DBTable = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DBName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(140, 259);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(200, 23);
            this.User.TabIndex = 14;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(140, 288);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(200, 23);
            this.Password.TabIndex = 15;
            // 
            // DBInsertName
            // 
            this.DBInsertName.Location = new System.Drawing.Point(140, 103);
            this.DBInsertName.Name = "DBInsertName";
            this.DBInsertName.Size = new System.Drawing.Size(200, 23);
            this.DBInsertName.TabIndex = 10;
            // 
            // IPDB
            // 
            this.IPDB.AcceptsReturn = true;
            this.IPDB.Location = new System.Drawing.Point(140, 58);
            this.IPDB.Name = "IPDB";
            this.IPDB.Size = new System.Drawing.Size(200, 23);
            this.IPDB.TabIndex = 9;
            // 
            // OldEANText
            // 
            this.OldEANText.AutoSize = true;
            this.OldEANText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OldEANText.Location = new System.Drawing.Point(12, 9);
            this.OldEANText.Name = "OldEANText";
            this.OldEANText.Size = new System.Drawing.Size(325, 25);
            this.OldEANText.TabIndex = 14;
            this.OldEANText.Text = "Ustawienia połączenia z bazą danych";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "IP Bazy danych";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Baza danych INSERT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Użytkownik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Hasło";
            // 
            // DBSaveButton
            // 
            this.DBSaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(187)))));
            this.DBSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DBSaveButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DBSaveButton.ForeColor = System.Drawing.Color.White;
            this.DBSaveButton.Location = new System.Drawing.Point(128, 328);
            this.DBSaveButton.Name = "DBSaveButton";
            this.DBSaveButton.Size = new System.Drawing.Size(100, 40);
            this.DBSaveButton.TabIndex = 16;
            this.DBSaveButton.Text = "Zapisz";
            this.DBSaveButton.UseVisualStyleBackColor = false;
            this.DBSaveButton.Click += new System.EventHandler(this.DBSaveButton_Click);
            // 
            // DBInsertTable
            // 
            this.DBInsertTable.Location = new System.Drawing.Point(140, 132);
            this.DBInsertTable.Name = "DBInsertTable";
            this.DBInsertTable.Size = new System.Drawing.Size(200, 23);
            this.DBInsertTable.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Tabela INSERT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Tabela";
            // 
            // DBTable
            // 
            this.DBTable.Location = new System.Drawing.Point(140, 209);
            this.DBTable.Name = "DBTable";
            this.DBTable.Size = new System.Drawing.Size(200, 23);
            this.DBTable.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "Baza danych ";
            // 
            // DBName
            // 
            this.DBName.Location = new System.Drawing.Point(140, 180);
            this.DBName.Name = "DBName";
            this.DBName.Size = new System.Drawing.Size(200, 23);
            this.DBName.TabIndex = 12;
            // 
            // Bazadanych
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 380);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DBTable);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DBName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DBInsertTable);
            this.Controls.Add(this.DBSaveButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OldEANText);
            this.Controls.Add(this.IPDB);
            this.Controls.Add(this.DBInsertName);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.User);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Bazadanych";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ustawienia połączenia z bazą danych";
            this.Load += new System.EventHandler(this.Bazadanych_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox DBInsertName;
        private System.Windows.Forms.TextBox IPDB;
        private System.Windows.Forms.Label OldEANText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DBSaveButton;
        private System.Windows.Forms.TextBox DBInsertTable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DBTable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DBName;
    }
}