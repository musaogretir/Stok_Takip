namespace Stok_Takip
{
    public partial class Form1 : Form
    {
        public static ListBox l;
        public static int index;
        public Form1()
        {
            InitializeComponent();
        }

        private void kategoriEkleDuzenle_Click(object sender, EventArgs e)
        {
            categoryAddEdit categoryAddEdit = new categoryAddEdit();
            categoryAddEdit.TopLevel = false;
            this.panel1.Controls.Add(categoryAddEdit);
            categoryAddEdit.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}