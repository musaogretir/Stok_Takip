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
    public partial class categoryAddEdit : Form
    {
        public categoryAddEdit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mesaj = "";

            if (textBox1.Text.Trim() != "")
            {
                if (!listBox1.Items.Contains(textBox1.Text.Trim()))
                {
                    listBox1.Items.Add(textBox1.Text.Trim());
                }
                else
                {
                    mesaj = "Bu kategori mevcut.\nKontrol ediniz.";
                }
            }
            else
            {
                mesaj = "Kategori adı boş olamaz.";
            }

            if (mesaj != "") MessageBox.Show(mesaj, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button2_Click(object sender, EventArgs iva)
        {
            if (listBox1.SelectedIndex > -1)
            {
                Form1.l = listBox1;
                Form1.index = listBox1.SelectedIndex;

                inputBox ib = new inputBox();
                ib.yeniDeger.Text = listBox1.GetItemText(listBox1.SelectedItem);
                ib.ShowDialog();
            }
        }

       
    }
}
