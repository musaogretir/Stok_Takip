namespace Stok_Takip
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Dosya = new System.Windows.Forms.ToolStripMenuItem();
            this.cikis = new System.Windows.Forms.ToolStripMenuItem();
            this.katIslem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriEkleDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.stokIslem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokEkleDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.stokListesi = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkinda = new System.Windows.Forms.ToolStripMenuItem();
            this.progHakkinda = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Dosya,
            this.katIslem,
            this.stokIslem,
            this.hakkinda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Dosya
            // 
            this.Dosya.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cikis});
            this.Dosya.Name = "Dosya";
            this.Dosya.Size = new System.Drawing.Size(51, 20);
            this.Dosya.Text = "Dosya";
            // 
            // cikis
            // 
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(99, 22);
            this.cikis.Text = "Çıkış";
            // 
            // katIslem
            // 
            this.katIslem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriEkleDuzenle});
            this.katIslem.Name = "katIslem";
            this.katIslem.Size = new System.Drawing.Size(110, 20);
            this.katIslem.Text = "Kategori İşlemleri";
            // 
            // kategoriEkleDuzenle
            // 
            this.kategoriEkleDuzenle.Name = "kategoriEkleDuzenle";
            this.kategoriEkleDuzenle.Size = new System.Drawing.Size(195, 22);
            this.kategoriEkleDuzenle.Text = "Kategori Ekle / Düzenle";
            this.kategoriEkleDuzenle.Click += new System.EventHandler(this.kategoriEkleDuzenle_Click);
            // 
            // stokIslem
            // 
            this.stokIslem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stokEkleDuzenle,
            this.stokListesi});
            this.stokIslem.Name = "stokIslem";
            this.stokIslem.Size = new System.Drawing.Size(89, 20);
            this.stokIslem.Text = "Stok İşlemleri";
            // 
            // stokEkleDuzenle
            // 
            this.stokEkleDuzenle.Name = "stokEkleDuzenle";
            this.stokEkleDuzenle.Size = new System.Drawing.Size(174, 22);
            this.stokEkleDuzenle.Text = "Stok Ekle / Düzenle";
            // 
            // stokListesi
            // 
            this.stokListesi.Name = "stokListesi";
            this.stokListesi.Size = new System.Drawing.Size(174, 22);
            this.stokListesi.Text = "Stok Listesi";
            // 
            // hakkinda
            // 
            this.hakkinda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progHakkinda});
            this.hakkinda.Name = "hakkinda";
            this.hakkinda.Size = new System.Drawing.Size(69, 20);
            this.hakkinda.Text = "Hakkında";
            // 
            // progHakkinda
            // 
            this.progHakkinda.Name = "progHakkinda";
            this.progHakkinda.Size = new System.Drawing.Size(173, 22);
            this.progHakkinda.Text = "Program Hakkında";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(16, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 594);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 633);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem Dosya;
        private ToolStripMenuItem cikis;
        private ToolStripMenuItem katIslem;
        private ToolStripMenuItem kategoriEkleDuzenle;
        private ToolStripMenuItem stokIslem;
        private ToolStripMenuItem stokEkleDuzenle;
        private ToolStripMenuItem stokListesi;
        private ToolStripMenuItem hakkinda;
        private ToolStripMenuItem progHakkinda;
        private Panel panel1;
    }
}