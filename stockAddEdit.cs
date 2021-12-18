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
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
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
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex > -1)
            {
                panel4.Enabled = true;
            }
            else
            {
                maskedTextBox1.Text = "";
                panel4.Enabled = false;
            }
        }
        
        private void button14_Click(object sender, EventArgs e)//Değişiklikleri kaydet
        {
            JSON j = new JSON();
            j.JSONsaveFile("stok.JSON", Form1.kategoriler);

            MessageBox.Show("Değişiklikler kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
    }
}
