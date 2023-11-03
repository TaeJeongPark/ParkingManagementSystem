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
        }
    }
}
