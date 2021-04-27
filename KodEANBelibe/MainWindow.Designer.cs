
namespace KodEANBelibe
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.NewEAN = new System.Windows.Forms.Button();
            this.NewEANtext = new System.Windows.Forms.Label();
            this.EANCode = new System.Windows.Forms.TextBox();
            this.DBButton = new System.Windows.Forms.Button();
            this.CodeListButton = new System.Windows.Forms.Button();
            this.Symbol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ListaSymboli = new System.Windows.Forms.ListView();
            this.SymbolHeader = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // NewEAN
            // 
            this.NewEAN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(187)))));
            this.NewEAN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewEAN.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewEAN.ForeColor = System.Drawing.Color.White;
            this.NewEAN.Location = new System.Drawing.Point(379, 50);
            this.NewEAN.Name = "NewEAN";
            this.NewEAN.Size = new System.Drawing.Size(180, 65);
            this.NewEAN.TabIndex = 2;
            this.NewEAN.Text = "Wygeneruj i zapisz nowy kod produktu";
            this.NewEAN.UseVisualStyleBackColor = false;
            this.NewEAN.Click += new System.EventHandler(this.NewEAN_Click);
            // 
            // NewEANtext
            // 
            this.NewEANtext.AutoSize = true;
            this.NewEANtext.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewEANtext.Location = new System.Drawing.Point(19, 18);
            this.NewEANtext.Name = "NewEANtext";
            this.NewEANtext.Size = new System.Drawing.Size(140, 25);
            this.NewEANtext.TabIndex = 4;
            this.NewEANtext.Text = "Wygeneruj kod";
            // 
            // EANCode
            // 
            this.EANCode.Location = new System.Drawing.Point(111, 102);
            this.EANCode.Name = "EANCode";
            this.EANCode.ReadOnly = true;
            this.EANCode.Size = new System.Drawing.Size(245, 27);
            this.EANCode.TabIndex = 5;
            // 
            // DBButton
            // 
            this.DBButton.BackColor = System.Drawing.Color.Transparent;
            this.DBButton.FlatAppearance.BorderSize = 0;
            this.DBButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DBButton.ForeColor = System.Drawing.Color.White;
            this.DBButton.Image = ((System.Drawing.Image)(resources.GetObject("DBButton.Image")));
            this.DBButton.Location = new System.Drawing.Point(542, -2);
            this.DBButton.Name = "DBButton";
            this.DBButton.Size = new System.Drawing.Size(40, 40);
            this.DBButton.TabIndex = 6;
            this.DBButton.UseVisualStyleBackColor = false;
            this.DBButton.Click += new System.EventHandler(this.DBButton_Click);
            this.DBButton.MouseLeave += new System.EventHandler(this.DBButton_HoverLeave);
            this.DBButton.MouseHover += new System.EventHandler(this.DBButton_Hover);
            // 
            // CodeListButton
            // 
            this.CodeListButton.BackColor = System.Drawing.Color.SlateGray;
            this.CodeListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CodeListButton.ForeColor = System.Drawing.Color.White;
            this.CodeListButton.Location = new System.Drawing.Point(379, 121);
            this.CodeListButton.Name = "CodeListButton";
            this.CodeListButton.Size = new System.Drawing.Size(180, 45);
            this.CodeListButton.TabIndex = 8;
            this.CodeListButton.Text = "Lista kodów";
            this.CodeListButton.UseVisualStyleBackColor = false;
            this.CodeListButton.Click += new System.EventHandler(this.CodeListButton_Click);
            // 
            // Symbol
            // 
            this.Symbol.Location = new System.Drawing.Point(111, 69);
            this.Symbol.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.Symbol.Name = "Symbol";
            this.Symbol.Size = new System.Drawing.Size(245, 27);
            this.Symbol.TabIndex = 9;
            this.Symbol.TextChanged += new System.EventHandler(this.Symbol_Change);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Symbol";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Kod";
            // 
            // ListaSymboli
            // 
            this.ListaSymboli.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SymbolHeader});
            this.ListaSymboli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListaSymboli.FullRowSelect = true;
            this.ListaSymboli.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ListaSymboli.HideSelection = false;
            this.ListaSymboli.Location = new System.Drawing.Point(111, 95);
            this.ListaSymboli.Name = "ListaSymboli";
            this.ListaSymboli.Size = new System.Drawing.Size(245, 80);
            this.ListaSymboli.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ListaSymboli.TabIndex = 14;
            this.ListaSymboli.UseCompatibleStateImageBehavior = false;
            this.ListaSymboli.View = System.Windows.Forms.View.Details;
            this.ListaSymboli.Visible = false;
            // 
            // SymbolHeader
            // 
            this.SymbolHeader.Text = "Symbol";
            this.SymbolHeader.Width = 220;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(583, 185);
            this.Controls.Add(this.ListaSymboli);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Symbol);
            this.Controls.Add(this.CodeListButton);
            this.Controls.Add(this.DBButton);
            this.Controls.Add(this.EANCode);
            this.Controls.Add(this.NewEANtext);
            this.Controls.Add(this.NewEAN);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generator wewnętrznych kodów Belibe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button NewEAN;
        private System.Windows.Forms.Label NewEANtext;
        private System.Windows.Forms.TextBox EANCode;
        private System.Windows.Forms.Button DBButton;
        private System.Windows.Forms.Button CodeListButton;
        private System.Windows.Forms.TextBox Symbol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView ListaSymboli;
        private System.Windows.Forms.ColumnHeader SymbolHeader;
    }
}

