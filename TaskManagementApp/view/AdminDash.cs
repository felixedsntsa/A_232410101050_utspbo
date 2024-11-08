using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagementApp.Model;

namespace TaskManagementApp.view
{
    public partial class AdminDash : Form
    {
        List<M_Tugas> list = new List<M_Tugas>();
        public AdminDash()
        {
            InitializeComponent();
            M_Tugas tugas1 = new M_Tugas();
            tugas1.Judul = "PBO";
            tugas1.Deskripsi = "WinForm";
            tugas1.Deadline = "10 Oktober 2024";
            list.Add(tugas1);
            dataGridViewTugasAdmin.DataSource = list;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
