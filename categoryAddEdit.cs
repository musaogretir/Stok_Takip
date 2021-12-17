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

        private void categoryAddEdit_Load(object sender, EventArgs e)
        {
            foreach (category c in Form1.kategoriler)
            {
                listBox1.Items.Add(c.categoryName);
            }
        }

        private void comboBox1_Enter(object sender, EventArgs e)//Seviye 1 kategori
        {
            comboBox1.DataSource = null;
            comboBox1.Items.Clear();
            comboBox1.DataSource = listBox1.Items;
        }

        private void comboBox2_Enter(object sender, EventArgs e)//Seviye 2 kategori
        {
            comboBox2.DataSource = null;
            comboBox2.Items.Clear();
            comboBox2.DataSource = listBox2.Items;
        }

        private void comboBox3_Enter(object sender, EventArgs e)//Seviye 3 kategori
        {
            comboBox3.DataSource = null;
            comboBox3.Items.Clear();
            comboBox3.DataSource = listBox3.Items;
        }

        #region Ana Kategori İşlemleri
        private void button1_Click(object sender, EventArgs e)
        {
            string mesaj = "", c = textBox1.Text.Trim();

            if ( c != "")
            {
                if (!listBox1.Items.Contains(c))
                {
                    listBox1.Items.Add(c);

                    category category = new category(Form1.categoryId, c, 0, new List<category>());

                    Form1.categoryId++;

                    Form1.kategoriler.Add(category);
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
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Kategori ve bağlı alt kategoriler silinecek.\nEmin misiniz?","Dikkat",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);

            if (dr == DialogResult.OK)
            {                
                Form1.kategoriler.RemoveAt(Form1.kategoriler.FindIndex(s => s.categoryName == listBox1.GetItemText(listBox1.SelectedItem)));
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                button2.Enabled = button3.Enabled = true;
            }
            else
            {
                button2.Enabled = button3.Enabled = false;
            }
        }

        #endregion

        #region Seviye 1 Kategori İşlemleri
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//Seviye 1 kategori seçim
        {
            if (comboBox1.SelectedIndex > -1)
            {
                textBox2.Enabled = true;
                listBox2.Items.Clear();

                foreach (category c in Form1.kategoriler)//Seçilen kategoriye ait alt kategorileri getir
                {
                    if (c.categoryName == comboBox1.GetItemText(comboBox1.SelectedItem))
                    {
                        foreach (category item in c.childCategories)
                        {
                            listBox2.Items.Add(item.categoryName);
                        }
                    }
                }
            }
            else
            {
                textBox2.Text = "";
                textBox2.Enabled = false;
            }
           
        }

        private void button6_Click(object sender, EventArgs e)//Seviye 1 kategori ekle
        {
            string mesaj = "", k1 = textBox2.Text.Trim();
            string secim = comboBox1.GetItemText(comboBox1.SelectedItem);

            if (k1 != "")
            {
                if (!listBox2.Items.Contains(k1))
                {
                    listBox2.Items.Add(k1);

                    int index = Form1.kategoriler.FindIndex(s => s.categoryName == secim);

                    int catID = Form1.kategoriler[index].categoryId;

                    if (index > -1) Form1.kategoriler[index].childCategories.Add(new category(Form1.kategoriler[index].childCategories.Count, k1,catID,new List<category>()));
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

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex > -1)
            {
                button4.Enabled = button5.Enabled = true;
            }
            else
            {
                button4.Enabled = button5.Enabled = false;
            }
        }
        private void button5_Click(object sender, EventArgs e)//Seviye 1 Güncelle Butonu
        {

        }
        private void button4_Click(object sender, EventArgs e)//Seviye 1 Sil Butonu
        {

        }

        #endregion

        #region Seviye 2 Kategori İşlemleri
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)//Seviye 2 Kategori Seçimi
        {
            if (comboBox2.SelectedIndex > -1)
            {
                textBox3.Enabled = true;
                listBox3.Items.Clear();

                foreach (category c1 in Form1.kategoriler)//Seçilen kategoriye ait alt kategorileri getir
                {
                    if (c1.categoryName == comboBox1.GetItemText(comboBox1.SelectedItem))
                    {
                        foreach (category c2 in c1.childCategories)
                        {
                            if (c2.categoryName == comboBox2.GetItemText(comboBox2.SelectedItem))
                            {
                                foreach (category c3 in c2.childCategories)
                                {
                                    listBox3.Items.Add(c3.categoryName);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                textBox3.Text = "";
                textBox3.Enabled = false;
            }
        }
        private void button9_Click(object sender, EventArgs e)//Seviye 2 Ekle Butonu
        {
            string mesaj = "", k2 = textBox3.Text.Trim();
            string secim1 = comboBox1.GetItemText(comboBox1.SelectedItem);
            string secim2 = comboBox2.GetItemText(comboBox2.SelectedItem);

            if (k2 != "")
            {
                if (!listBox3.Items.Contains(k2))
                {
                    listBox3.Items.Add(k2);

                    int parentID=0, mainCAT=0, index = Form1.kategoriler.FindIndex(s => s.categoryName == secim1);

                    int childCatIndex = Form1.kategoriler[index].childCategories.FindIndex(s => s.categoryName == secim2);

                    foreach (category c1 in Form1.kategoriler)
                    {
                        foreach (category c2 in c1.childCategories)
                        {
                            if (c2.categoryName == secim2)
                            {
                                mainCAT = c2.categoryId;
                                parentID = c2.parentId;
                                Form1.kategoriler[index].childCategories[childCatIndex].childCategories.Add(new category(Form1.kategoriler[index].childCategories.Count, k2, parentID, new List<category>()));
                            }
                        }
                    }
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
        private void button8_Click(object sender, EventArgs e)//Seviye 2 Güncelle Butonu
        {

        }
        private void button7_Click(object sender, EventArgs e)//Seviye 2 Sil Butonu
        {

        }
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex > -1)
            {
                button7.Enabled = button8.Enabled = true;
            }
            else
            {
                button7.Enabled = button8.Enabled = false;
            }
        }
        #endregion

        #region Seviye 3 Kategori İşlemleri
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)//Seviye 3 Kategori Seçimi
        {
            if (comboBox3.SelectedIndex > -1)
            {
                textBox4.Enabled = true;
                listBox4.Items.Clear();

                foreach (category c1 in Form1.kategoriler)//Seçilen kategoriye ait alt kategorileri getir
                {
                    if (c1.categoryName == comboBox1.GetItemText(comboBox1.SelectedItem))
                    {
                        foreach (category c2 in c1.childCategories)
                        {
                            foreach (category c3 in c2.childCategories)
                            {
                                if (c3.categoryName == comboBox3.GetItemText(comboBox3.SelectedItem))
                                {
                                    foreach (category c4 in c3.childCategories)
                                    {
                                        listBox4.Items.Add(c4.categoryName);
                                    }
                                }
                            }                            
                        }
                    }
                }
            }
            else
            {
                textBox3.Text = "";
                textBox3.Enabled = false;
            }
        }
        private void button12_Click(object sender, EventArgs e)//Seviye 3 Ekle Butonu
        {
            string mesaj = "", k3 = textBox4.Text.Trim();
            string secim1 = comboBox1.GetItemText(comboBox1.SelectedItem);
            string secim2 = comboBox2.GetItemText(comboBox2.SelectedItem); ;
            string secim3 = comboBox3.GetItemText(comboBox3.SelectedItem); ;

            if (!listBox4.Items.Contains(k3))
            {
                listBox4.Items.Add(k3);

                int parentID = 0, mainCAT = 0, index = Form1.kategoriler.FindIndex(s => s.categoryName == secim1);

                int childCatIndex1 = Form1.kategoriler[index].childCategories.FindIndex(s => s.categoryName == secim2);

                int childCatIndex2 = Form1.kategoriler[index].childCategories[childCatIndex1].childCategories.FindIndex(s => s.categoryName == secim3);

                foreach (category c1 in Form1.kategoriler)
                {
                    foreach (category c2 in c1.childCategories)
                    {
                        foreach (category c3 in c2.childCategories)
                        {
                            if (c3.categoryName == secim3)
                            {
                                mainCAT = c3.categoryId;
                                parentID = c3.parentId;
                                Form1.kategoriler[index].childCategories[childCatIndex1].childCategories[childCatIndex2].childCategories.Add(
                                    new category(Form1.kategoriler[index].childCategories.Count, k3, parentID, new List<category>()));
                            }
                        }
                    }
                }
            }
            else
            {
                mesaj = "Bu kategori mevcut.\nKontrol ediniz.";
            }

            if (mesaj != "") MessageBox.Show(mesaj, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox4.SelectedIndex > -1)
            {
                button10.Enabled = button11.Enabled = true;
            }
            else
            {
                button10.Enabled = button11.Enabled = false;
            }
        }


        #endregion

        private void button14_Click(object sender, EventArgs e)//Değişiklikleri kaydet
        {
            JSON j = new JSON();
            j.JSONsaveFile("stok.JSON", Form1.kategoriler);

            MessageBox.Show("Değişiklikler kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
