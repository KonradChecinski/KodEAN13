
namespace KodEANBelibe
{
    partial class Lista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista));
            this.List = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Symbol = new System.Windows.Forms.ColumnHeader();
            this.KodKreskowy = new System.Windows.Forms.ColumnHeader();
            this.ListDeleteButton = new System.Windows.Forms.Button();
            this.ListOkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // List
            // 
            this.List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Symbol,
            this.KodKreskowy});
            this.List.FullRowSelect = true;
            this.List.GridLines = true;
            this.List.HideSelection = false;
            this.List.Location = new System.Drawing.Point(12, 12);
            this.List.MultiSelect = false;
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(458, 522);
            this.List.TabIndex = 0;
            this.List.UseCompatibleStateImageBehavior = false;
            this.List.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Symbol
            // 
            this.Symbol.Text = "Symbol";
            this.Symbol.Width = 220;
            // 
            // KodKreskowy
            // 
            this.KodKreskowy.Text = "Kod kreskowy";
            this.KodKreskowy.Width = 150;
            // 
            // ListDeleteButton
            // 
            this.ListDeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ListDeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(187)))));
            this.ListDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListDeleteButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ListDeleteButton.ForeColor = System.Drawing.Color.White;
            this.ListDeleteButton.Location = new System.Drawing.Point(476, 12);
            this.ListDeleteButton.Name = "ListDeleteButton";
            this.ListDeleteButton.Size = new System.Drawing.Size(100, 40);
            this.ListDeleteButton.TabIndex = 21;
            this.ListDeleteButton.Text = "Usuń";
            this.ListDeleteButton.UseVisualStyleBackColor = false;
            this.ListDeleteButton.Click += new System.EventHandler(this.ListDeleteButton_Click);
            // 
            // ListOkButton
            // 
            this.ListOkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ListOkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(187)))));
            this.ListOkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListOkButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ListOkButton.ForeColor = System.Drawing.Color.White;
            this.ListOkButton.Location = new System.Drawing.Point(476, 494);
            this.ListOkButton.Name = "ListOkButton";
            this.ListOkButton.Size = new System.Drawing.Size(100, 40);
            this.ListOkButton.TabIndex = 22;
            this.ListOkButton.Text = "OK";
            this.ListOkButton.UseVisualStyleBackColor = false;
            this.ListOkButton.Click += new System.EventHandler(this.ListOkButton_Click);
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 546);
            this.Controls.Add(this.ListOkButton);
            this.Controls.Add(this.ListDeleteButton);
            this.Controls.Add(this.List);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 585);
            this.Name = "Lista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista kodów wewnętrznych";
            this.Load += new System.EventHandler(this.Lista_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView List;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Symbol;
        private System.Windows.Forms.ColumnHeader KodKreskowy;
        private System.Windows.Forms.Button ListDeleteButton;
        private System.Windows.Forms.Button ListOkButton;
    }
}