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
    public partial class stockAddEdit : Form
    {
        public stockAddEdit()
        {
            InitializeComponent();
        }  
        private void stockAddEdit_Load(object sender, EventArgs e)
        {
            foreach (category c in Form1.kategoriler)
            {
                comboBox1.Items.Add(c.categoryName);
                sdSv1.Items.Add(c.categoryName);
            }
        }


        #region Stok Girişi
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                comboBox4.Items.Clear();

                comboBox2.Enabled = true;

                int mainCat = Form1.kategoriler
                    .FindIndex(s => s.categoryName == comboBox1.GetItemText(comboBox1.SelectedItem));

                foreach (category c in Form1.kategoriler[mainCat].childCategories)
                {
                    comboBox2.Items.Add(c.categoryName);
                }
            }
            else
            {
                comboBox2.Enabled = false;
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex > -1)
            {
                comboBox3.Items.Clear();
                comboBox4.Items.Clear();

                comboBox3.Enabled = true;

                int mainCat = Form1.kategoriler
                    .FindIndex(s => s.categoryName == comboBox1.GetItemText(comboBox1.SelectedItem));

                int subCat = Form1.kategoriler[mainCat]
                    .childCategories
                    .FindIndex(s => s.categoryName == comboBox2.GetItemText(comboBox2.SelectedItem));

                foreach (category c in Form1.kategoriler[mainCat].childCategories[subCat].childCategories)
                {
                    comboBox3.Items.Add(c.categoryName);
                }
            }
            else
            {
                comboBox3.Enabled = false;
            }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex > -1)
            {
                comboBox4.Items.Clear();
                comboBox4.Enabled = true;

                int mainCat = Form1.kategoriler
                    .FindIndex(s => s.categoryName == comboBox1.GetItemText(comboBox1.SelectedItem));

                int subCat1 = Form1.kategoriler[mainCat]
                    .childCategories
                    .FindIndex(s => s.categoryName == comboBox2.GetItemText(comboBox2.SelectedItem));

                int subCat2 = Form1.kategoriler[mainCat]
                    .childCategories[subCat1]
                    .childCategories
                    .FindIndex(s => s.categoryName == comboBox3.GetItemText(comboBox3.SelectedItem));

                foreach (category c in Form1.kategoriler[mainCat].childCategories[subCat1].childCategories[subCat2].childCategories)
                {
                    comboBox4.Items.Add(c.categoryName);
                }
            }
            else
            {
                comboBox4.Enabled = false;
            }
        }

        private delegate void kombo4(object sender, EventArgs e);
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] cats = new string[]
            {
                comboBox1.GetItemText(comboBox1.SelectedItem),
                comboBox2.GetItemText(comboBox2.SelectedItem),
                comboBox3.GetItemText(comboBox3.SelectedItem),
                comboBox4.GetItemText(comboBox4.SelectedItem)
            };

            int[] levels = findCatIndex(cats);

            if (comboBox4.SelectedIndex > -1)
            {
                panel4.Enabled = true;
                label8.Text = Form1.kategoriler[levels[0]]
                                   .childCategories[levels[1]]
                                   .childCategories[levels[2]]
                                   .childCategories[levels[3]]
                                   .stockAmount
                                   .ToString();

                maskedTextBox1.Focus();
            }
            else
            {
                maskedTextBox1.Text = "";
                panel4.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)//Stok Ekle Butonu
        {
            kombo4 k = comboBox4_SelectedIndexChanged;

            string[] cats = new string[]
            {
                comboBox1.GetItemText(comboBox1.SelectedItem),
                comboBox2.GetItemText(comboBox2.SelectedItem),
                comboBox3.GetItemText(comboBox3.SelectedItem),
                comboBox4.GetItemText(comboBox4.SelectedItem)
            };

            int[] levels = findCatIndex(cats);

            int miktar;
            if (Int32.TryParse(maskedTextBox1.Text, out miktar) == true)
            {                
                Form1.kategoriler[levels[0]]
                        .childCategories[levels[1]]
                        .childCategories[levels[2]]
                        .childCategories[levels[3]]
                        .stockAmount += miktar;

                maskedTextBox1.Text = "";
                k(sender, e);
                MessageBox.Show("Stok eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            } 
        }

        private void button14_Click(object sender, EventArgs e)//Değişiklikleri kaydet
        {
            JSON j = new JSON();
            j.JSONsaveFile("stok.JSON", Form1.kategoriler);

            MessageBox.Show("Değişiklikler kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int[] findCatIndex(string[] levels)
        {
            int mainCat = Form1.kategoriler
                    .FindIndex(s => s.categoryName == levels[0]);

            int subCat1 = Form1.kategoriler[mainCat]
                .childCategories
                .FindIndex(s => s.categoryName == levels[1]);

            int subCat2 = Form1.kategoriler[mainCat]
                .childCategories[subCat1]
                .childCategories
                .FindIndex(s => s.categoryName == levels[2]);

            int subCat3 = Form1.kategoriler[mainCat]
                .childCategories[subCat1]
                .childCategories[subCat2]
                .childCategories
                .FindIndex(s => s.categoryName == levels[3]);

            return new int[] { mainCat, subCat1, subCat2, subCat3 };
        }

        #endregion




        #region Stok Düzelt
        private void sdSv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sdSv1.SelectedIndex > -1)
            {
                sdSv2.Items.Clear();
                sdSv3.Items.Clear();
                sdSv4.Items.Clear();

                sdSv2.Enabled = true;

                int mainCat = Form1.kategoriler
                    .FindIndex(s => s.categoryName == sdSv1.GetItemText(sdSv1.SelectedItem));

                foreach (category c in Form1.kategoriler[mainCat].childCategories)
                {
                    sdSv2.Items.Add(c.categoryName);
                }
            }
            else
            {
                sdSv2.Enabled = false;
            }
        }

        private void sdSv2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sdSv2.SelectedIndex > -1)
            {
                sdSv3.Items.Clear();
                sdSv4.Items.Clear();

                sdSv3.Enabled = true;

                int mainCat = Form1.kategoriler
                    .FindIndex(s => s.categoryName == sdSv1.GetItemText(sdSv1.SelectedItem));

                int subCat = Form1.kategoriler[mainCat]
                    .childCategories
                    .FindIndex(s => s.categoryName == sdSv2.GetItemText(sdSv2.SelectedItem));

                foreach (category c in Form1.kategoriler[mainCat].childCategories[subCat].childCategories)
                {
                    sdSv3.Items.Add(c.categoryName);
                }
            }
            else
            {
                sdSv3.Enabled = false;
            }
        }

        private void sdSv3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sdSv3.SelectedIndex > -1)
            {
                sdSv4.Items.Clear();
                sdSv4.Enabled = true;

                int mainCat = Form1.kategoriler
                    .FindIndex(s => s.categoryName == sdSv1.GetItemText(sdSv1.SelectedItem));

                int subCat1 = Form1.kategoriler[mainCat]
                    .childCategories
                    .FindIndex(s => s.categoryName == sdSv2.GetItemText(sdSv2.SelectedItem));

                int subCat2 = Form1.kategoriler[mainCat]
                    .childCategories[subCat1]
                    .childCategories
                    .FindIndex(s => s.categoryName == sdSv3.GetItemText(sdSv3.SelectedItem));

                foreach (category c in Form1.kategoriler[mainCat].childCategories[subCat1].childCategories[subCat2].childCategories)
                {
                    sdSv4.Items.Add(c.categoryName);
                }
            }
            else
            {
                sdSv4.Enabled = false;
            }
        }

        private void sdSv4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] cats = new string[]
            {
                sdSv1.GetItemText(sdSv1.SelectedItem),
                sdSv2.GetItemText(sdSv2.SelectedItem),
                sdSv3.GetItemText(sdSv3.SelectedItem),
                sdSv4.GetItemText(sdSv4.SelectedItem)
            };

            int[] levels = findCatIndex(cats);

            if (sdSv4.SelectedIndex > -1)
            {
                panel6.Enabled = true;
                label11.Text = Form1.kategoriler[levels[0]]
                                    .childCategories[levels[1]]
                                    .childCategories[levels[2]]
                                    .childCategories[levels[3]]
                                    .stockAmount
                                    .ToString();

                maskedTextBox2.Focus();
            }
            else
            {
                maskedTextBox2.Text = "";
                panel6.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kombo4 k = sdSv4_SelectedIndexChanged;

            string[] cats = new string[]
            {
                sdSv1.GetItemText(sdSv1.SelectedItem),
                sdSv2.GetItemText(sdSv2.SelectedItem),
                sdSv3.GetItemText(sdSv3.SelectedItem),
                sdSv4.GetItemText(sdSv4.SelectedItem)
            };

            int[] levels = findCatIndex(cats);

            int miktar;
            if (Int32.TryParse(maskedTextBox2.Text, out miktar) == true)
            {
                Form1.kategoriler[levels[0]]
                        .childCategories[levels[1]]
                        .childCategories[levels[2]]
                        .childCategories[levels[3]]
                        .stockAmount = miktar;

                maskedTextBox2.Text = "";
                k(sender, e);
                MessageBox.Show("Stok düzeltildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        #endregion


    }
}
