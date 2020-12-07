namespace Drivingschool
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.csvImportálásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Név = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Születési_idő = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Születési_dátum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Anyja_neve = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ország = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Irányítószám = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Település = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cím = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SZIG_szám = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kategória = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.azonosito = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1120, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fájlToolStripMenuItem
            // 
            this.fájlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.csvImportálásaToolStripMenuItem});
            this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            this.fájlToolStripMenuItem.Size = new System.Drawing.Size(44, 26);
            this.fájlToolStripMenuItem.Text = "fájl";
            // 
            // csvImportálásaToolStripMenuItem
            // 
            this.csvImportálásaToolStripMenuItem.Name = "csvImportálásaToolStripMenuItem";
            this.csvImportálásaToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.csvImportálásaToolStripMenuItem.Text = "csv importálása";
            this.csvImportálásaToolStripMenuItem.Click += new System.EventHandler(this.csvImportálásaToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Név,
            this.Születési_idő,
            this.Születési_dátum,
            this.Anyja_neve,
            this.Ország,
            this.Irányítószám,
            this.Település,
            this.Cím,
            this.Telefon,
            this.Email,
            this.SZIG_szám,
            this.Kategória,
            this.azonosito});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 163);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1096, 255);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // Név
            // 
            this.Név.Text = "Név";
            // 
            // Születési_idő
            // 
            this.Születési_idő.Text = "Születési_idő";
            // 
            // Születési_dátum
            // 
            this.Születési_dátum.Text = "Születési_dátum";
            // 
            // Anyja_neve
            // 
            this.Anyja_neve.Text = "Anyja_neve";
            // 
            // Ország
            // 
            this.Ország.Text = "Ország";
            // 
            // Irányítószám
            // 
            this.Irányítószám.Text = "Irányítószám";
            // 
            // azonosito
            // 
            this.azonosito.Text = "Azonosító";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1006, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 556);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem csvImportálásaToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Név;
        private System.Windows.Forms.ColumnHeader Születési_idő;
        private System.Windows.Forms.ColumnHeader Születési_dátum;
        private System.Windows.Forms.ColumnHeader Anyja_neve;
        private System.Windows.Forms.ColumnHeader Ország;
        private System.Windows.Forms.ColumnHeader Irányítószám;
        private System.Windows.Forms.ColumnHeader Település;
        private System.Windows.Forms.ColumnHeader Cím;
        private System.Windows.Forms.ColumnHeader Telefon;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader SZIG_szám;
        private System.Windows.Forms.ColumnHeader Kategória;
        private System.Windows.Forms.ColumnHeader azonosito;
        private System.Windows.Forms.Button button1;
    }
}

