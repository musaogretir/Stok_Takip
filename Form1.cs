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
        }

        private void kategoriEkleDuzenle_Click(object sender, EventArgs e)
        {
            categoryAddEdit categoryAddEdit = new categoryAddEdit();
            categoryAddEdit.TopLevel = false;
            this.panel1.Controls.Add(categoryAddEdit);
            categoryAddEdit.Show();
        }

        
    }
}