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
    public partial class 출차정보 : Form
    {
        string carNum;

        public 출차정보(string carNum)
        {
            InitializeComponent();
            this.carNum = carNum;
        }

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        string conStr, sql;

        private void btn_out_Click(object sender, EventArgs e)
        {
            DateTime car_out = new DateTime(
                date_out.Value.Year, 
                date_out.Value.Month, 
                date_out.Value.Day, 
                int.Parse(si_out.Text), 
                int.Parse(bun_out.Text), 
                int.Parse(cho_out.Text));
            int money = int.Parse(tb_won.Text);

            sql = "UPDATE parkingTable SET timeout = @out, money = " + money + ", outcheck = 1 WHERE car_num = '" + tb_car.Text + "';";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@out", car_out);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();

            MessageBox.Show(tb_car.Text + "차량 결제 완료\n20분 내로 출차해 주세요.");

            this.Close();
            시작화면 시작 = new 시작화면();
            시작.Show();
        }

        private void 출차정보_Load(object sender, EventArgs e)
        {
            conStr = "Server=localhost;Database=inhaDB;Trusted_Connection=True;";
            conn = new SqlConnection(conStr);
            conn.Open();

            cmd = new SqlCommand();
            cmd.Connection = conn;

            sql = "SELECT * FROM parkingTable WHERE car_num like '%" + carNum + "%';";
            cmd.CommandText = sql;
            reader = cmd.ExecuteReader();

            byte[] bImage = null;

            if(reader.Read())
            {
                bImage = (byte[])reader[1];
                pictureBox1.Image = new Bitmap(new MemoryStream(bImage));

                DateTime dateIn = reader.GetDateTime(3);

                tb_car.Text = reader.GetString(2);
                date_in.Value = dateIn;
                si_in.Text = dateIn.Hour.ToString();
                bun_in.Text = dateIn.Minute.ToString();
                cho_in.Text = dateIn.Second.ToString();

                DateTime curDate = DateTime.Now;

                date_out.Value = curDate;
                si_out.Text = curDate.Hour.ToString();
                bun_out.Text = curDate.Minute.ToString();
                cho_out.Text = curDate.Second.ToString();

                double totalBun;
                TimeSpan p = curDate - dateIn;
                totalBun = p.TotalMinutes;
                int tempBun = (int) totalBun;
                int out_money = ((tempBun - 30) / 10) * 1000;
                tb_won.Text = out_money < 0 ? "0" : out_money.ToString();
            }
            else
            {

            }
            reader.Close();
        }
    }
}
