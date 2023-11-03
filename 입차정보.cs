using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class 입차정보 : Form
    {
        public 입차정보()
        {
            InitializeComponent();
        }

        string conStr;
        SqlConnection conn;
        SqlCommand cmd;


        private void btn_in_Click(object sender, EventArgs e)
        {
            Image pImage = pictureBox1.Image;
            string cNum = tb_car.Text;
            string y, m, d, si, bun, cho;

            y = date_in.Value.Year.ToString();
            m = date_in.Value.Month.ToString();
            d = date_in.Value.Day.ToString();
            si = date_in.Value.Hour.ToString();
            bun = date_in.Value.Minute.ToString();
            cho = date_in.Value.Second.ToString();

            string d_in = y + "-" + m + "-" + d + " " + si + ":" + bun + ":" + cho;

            DateTime pDateIn = Convert.ToDateTime(d_in);

            FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
            byte[] bImage = new byte[fs.Length];
            fs.Read(bImage, 0, (int)fs.Length);

            string sql = "INSERT INTO parkingTable (img, car_num, time_in, out_check) VALUES (@img, '" + cNum + "', @d_in, 0);";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@img", bImage);
            cmd.Parameters.AddWithValue("@d_in", pDateIn);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();

            fs.Close();

            MessageBox.Show(cNum + "차량의 입차가 완료되었습니다.");

            pictureBox1.Image = null;
            tb_car.Text = "";
            date_in.Value = DateTime.Now;
            si_in.Text = "";
            bun_in.Text = "";
            cho_in.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void 입차정보_Load(object sender, EventArgs e)
        {
            conStr = "Server=localhost;Database=inhaDB;Trusted_Connection=True;";
            conn = new SqlConnection(conStr);
            conn.Open();

            cmd = new SqlCommand();
            cmd.Connection = conn;

            for (int i = 0; i <= 23; i++)
            {
                if (i < 10) si_in.Items.Add("0" + i);
                else si_in.Items.Add(i);
            }

            for (int i = 0; i <= 59; i++)
            {
                if (i < 10)
                {
                    bun_in.Items.Add("0" + i);
                    cho_in.Items.Add("0" + i);
                }
                else
                {
                    bun_in.Items.Add(i);
                    cho_in.Items.Add(i);
                }
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            conn.Close();
            시작화면 시작 = new 시작화면();
            시작.Show();
        }

        private void 입차정보_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }
    }
}
