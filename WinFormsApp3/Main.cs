using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void groupBox_CusList_Enter(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btn_DbInfo_Click(object sender, EventArgs e)
        {
            int num = (int)new DbInput().ShowDialog();
        }

        private void btn_UsersInfo_Click(object sender, EventArgs e)
        {
            int num = (int)new UserInfo().ShowDialog();
        }

        private void btn_ProductInfo_Click(object sender, EventArgs e)
        {
            int num = (int)new ProductInfo().ShowDialog();
        }

        private void btn_Consulting_Click(object sender, EventArgs e)
        {
            int num = (int)new Consulting().ShowDialog();
        }


    }
}
