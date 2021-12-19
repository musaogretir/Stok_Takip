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
    public partial class stockList : Form
    {
        public stockList()
        {
            InitializeComponent();
        }

        private void stockList_Load(object sender, EventArgs e)
        {
            int i = 1;
            string kategori = "";

            List<category> liste = new List<category>();

            foreach (category c1 in Form1.kategoriler)
            {
                foreach (category c2 in c1.childCategories)
                {
                    foreach (category c3 in c2.childCategories)
                    {
                        foreach (category c4 in c3.childCategories)
                        {
                            kategori = c1.categoryName +" > "
                                                       + c2.categoryName + " > "
                                                       + c3.categoryName + " > "
                                                       + c4.categoryName;

                            liste.Add(new category(i, kategori, 0, null, c4.stockAmount));
                            i++;
                        }
                    }
                }
            }

            
            dataGridView1.DataSource = liste;

            dataGridView1.Columns[0].HeaderText = "SIRA";
            dataGridView1.Columns[0].Width = 80;

            dataGridView1.Columns[1].HeaderText = "ÜRÜN";
            dataGridView1.Columns[1].Width = 685;

            dataGridView1.Columns[2].Visible = false;

            dataGridView1.Columns[3].HeaderText = "MİKTAR";
            dataGridView1.Columns[3].Width = 80;

        }
    }
}
