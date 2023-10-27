using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class 시작화면 : Form
    {
        public 시작화면()
        {
            InitializeComponent();
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            입차정보 입차 = new 입차정보();
            입차.Show();
            this.Hide();
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            출차정보 출차 = new 출차정보();
            출차.Show();
            this.Hide();
        }
    }
}
