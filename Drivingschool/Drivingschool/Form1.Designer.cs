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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.csvImportálásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Név = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Születési_dátum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Születési_hely = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.button2 = new System.Windows.Forms.Button();
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
            this.menuStrip1.Size = new System.Drawing.Size(1374, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fájlToolStripMenuItem
            // 
            this.fájlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.csvImportálásaToolStripMenuItem});
            this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            this.fájlToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
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
            this.listView1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Név,
            this.Születési_dátum,
            this.Születési_hely,
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
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listView1.ForeColor = System.Drawing.Color.Black;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 71);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1355, 336);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // Név
            // 
            this.Név.Text = "Név";
            this.Név.Width = 78;
            // 
            // Születési_dátum
            // 
            this.Születési_dátum.DisplayIndex = 2;
            this.Születési_dátum.Text = "Születési_dátum";
            this.Születési_dátum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Születési_dátum.Width = 122;
            // 
            // Születési_hely
            // 
            this.Születési_hely.DisplayIndex = 1;
            this.Születési_hely.Text = "Születési_hely";
            this.Születési_hely.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Születési_hely.Width = 108;
            // 
            // Anyja_neve
            // 
            this.Anyja_neve.Text = "Anyja_neve";
            this.Anyja_neve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Anyja_neve.Width = 73;
            // 
            // Ország
            // 
            this.Ország.Text = "Ország";
            this.Ország.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ország.Width = 57;
            // 
            // Irányítószám
            // 
            this.Irányítószám.Text = "Irányítószám";
            this.Irányítószám.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Irányítószám.Width = 71;
            // 
            // Település
            // 
            this.Település.Text = "Település";
            this.Település.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Település.Width = 76;
            // 
            // Cím
            // 
            this.Cím.Text = "Cím";
            this.Cím.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cím.Width = 44;
            // 
            // Telefon
            // 
            this.Telefon.Text = "Telefon";
            this.Telefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Telefon.Width = 64;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Email.Width = 56;
            // 
            // SZIG_szám
            // 
            this.SZIG_szám.Text = "SZIG_szám";
            this.SZIG_szám.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SZIG_szám.Width = 90;
            // 
            // Kategória
            // 
            this.Kategória.Text = "Kategória";
            this.Kategória.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Kategória.Width = 71;
            // 
            // azonosito
            // 
            this.azonosito.Text = "Azonosító";
            this.azonosito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.azonosito.Width = 88;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(838, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(417, 451);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 48);
            this.button2.TabIndex = 3;
            this.button2.Text = "Export";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 535);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.ColumnHeader Születési_hely;
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
        private System.Windows.Forms.Button button2;
    }
}

