using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class 차량검색 : Form
    {
        public 차량검색()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        string conStr, sql;

        private void btn_search_Click(object sender, EventArgs e)
        {
            conStr = "Server=localhost;Database=inhaDB;Trusted_Connection=True;";
            conn = new SqlConnection(conStr);
            conn.Open();

            cmd = new SqlCommand();
            cmd.Connection = conn;

            string num = tb_num.Text;
            sql = "SELECT * FROM parkingTable WHERE car_num like '%" + num + "%';";
            cmd.CommandText = sql;
            reader = cmd.ExecuteReader();

            if(reader.Read())
            {
                출차정보 출차 = new 출차정보(num);
                출차.Show();
            }
            else
            {
                MessageBox.Show(num + " 번호의 차량이 없습니다.");
                tb_num.Text = "";
                tb_num.Focus();
            }
        }
    }
}
