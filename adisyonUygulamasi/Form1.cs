namespace adisyonUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            string kullaniciadi, sifre = " ";
            kullaniciadi = textBox_giris.Text;
            sifre = textBox_sifre.Text;

            if (kullaniciadi.ToLower()=="zeynep" && sifre=="2005")
            {
                //baska forma y�nlendirir. 
              
                uygulama uygulama = new uygulama();
                uygulama.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatal� giri�", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
