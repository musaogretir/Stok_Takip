using System.Text;

namespace Stok_Takip
{
    public partial class Form1 : Form
    {
        public static ListBox l;
        public static int index;
        public static int categoryId;
        public static List<category> kategoriler = new List<category>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            JSON j = new JSON();
            kategoriler = j.JSONread("stok.JSON",kategoriler);
            categoryId = kategoriler.Count();

            panel1.Controls.Clear();
            stockList stockList = new stockList();
            stockList.TopLevel = false;
            this.panel1.Controls.Add(stockList);
            stockList.Show();
        }

        private void kategoriEkleDuzenle_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            categoryAddEdit categoryAddEdit = new categoryAddEdit();
            categoryAddEdit.TopLevel = false;
            this.panel1.Controls.Add(categoryAddEdit);
            categoryAddEdit.Show();
        }

        private void stokEkleDuzenle_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            stockAddEdit stockAddEdit = new stockAddEdit();
            stockAddEdit.TopLevel = false;
            this.panel1.Controls.Add(stockAddEdit);
            stockAddEdit.Show();
        }

        private void stokListesi_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            stockList stockList = new stockList();
            stockList.TopLevel = false;
            this.panel1.Controls.Add(stockList);
            stockList.Show();
        }
    }
}