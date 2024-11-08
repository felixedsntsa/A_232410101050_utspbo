using TaskManagementApp.view;

namespace TaskManagementApp
{
    public partial class HalWelcome : Form
    {
        public HalWelcome()
        {
            InitializeComponent();
        }

        private void buttonHalTugas_Click(object sender, EventArgs e)
        {
            HalamanTugas halamantugas = new HalamanTugas();
            this.Hide();
            halamantugas.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HalLogin halLogin = new HalLogin();
            this.Hide();
            halLogin.Show();
        }
    }
}
