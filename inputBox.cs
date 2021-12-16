using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Takip
{
    public partial class inputBox : Form
    {
        public inputBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            guncelle(Form1.l, Form1.index, yeniDeger.Text);
            this.Close();
        }
        private void guncelle(ListBox l, int index, string deger)
        {
            l.Items.RemoveAt(index);
            l.Items.Insert(index, deger);
        }
    }
}
