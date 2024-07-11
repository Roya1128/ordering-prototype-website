using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace 程式期末POS點餐系統
{
    public partial class 結帳 : Form
    {
        public string[] str;
        public string tablenum;
        public 結帳(string[] s,string table)
        {
            InitializeComponent();
            str = s;
            tablenum = table;
        }


        private void 結帳_Load(object sender, EventArgs e)
        {
            textBox1.Text = "1";
            // TODO: 這行程式碼會將資料載入 'database1DataSet8.user' 資料表。您可以視需要進行移動或移除。
            this.userTableAdapter6.Fill(this.database1DataSet8.user);
            // TODO: 這行程式碼會將資料載入 'database1DataSet7.user' 資料表。您可以視需要進行移動或移除。
            this.userTableAdapter5.Fill(this.database1DataSet7.user);
            // TODO: 這行程式碼會將資料載入 'database1DataSet6.user' 資料表。您可以視需要進行移動或移除。
            this.userTableAdapter4.Fill(this.database1DataSet6.user);
            // TODO: 這行程式碼會將資料載入 'database1DataSet5.user' 資料表。您可以視需要進行移動或移除。
            this.userTableAdapter3.Fill(this.database1DataSet5.user);
            string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            //設定連線
            SqlConnection conn = new SqlConnection(strCon);
            //開啟連線
            conn.Open();
            //設定MSSQL


            //設定SqlDataAdapter變數=new SqlDataAdapter()
            if (str ==null){
                SqlCommand cmdd = new SqlCommand("select * from [user]", conn);
                //建立dataTable
                DataTable dataTable1 = new DataTable();
                SqlDataAdapter daa = new SqlDataAdapter(cmdd);
                daa.Fill(dataTable1);
                //設定dataGridView資料來源
                dataGridView1.DataSource = dataTable1;
                conn.Close();

            }
            else {
                SqlCommand cm = new SqlCommand("select * from[user] order by 訂單編號 DESC", conn);
                DataTable dt = new DataTable();
                //設定SqlDataAdapter變數=new SqlDataAdapter()
                SqlDataAdapter d = new SqlDataAdapter(cm);
                d.Fill(dt);
                if (dt.Rows.Count==0)
                {
                    string id = "1";
                    string strSQL = $"INSERT INTO[user](訂單編號,桌號,產品類別,產品名稱,單價,數量,金額)  VALUES('" + id + "','" + str[0] + "',N'" + str[1] + "',N'" + str[2] + "'," + str[3] + "," + str[4] + "," + int.Parse(str[5]) + ")";
                    SqlCommand cmd = new SqlCommand(strSQL, conn);
                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand("select * from [user]", conn);
                    //建立dataTable
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dataTable);
                    string s_sum = dataTable.Compute("SUM(金額)", "").ToString();
                    label4.Text = s_sum;
                    //設定dataGridView資料來源
                    dataGridView1.DataSource = dataTable;
                    conn.Close();
                }
                else
                {
                   
                    string id;
                    int id1;
                    id = dt.Rows[0]["訂單編號"].ToString();
                    id1 = int.Parse(id) + 1;
                    string strSQL = $"INSERT INTO[user](訂單編號,桌號,產品類別,產品名稱,單價,數量,金額)  VALUES('" +id1.ToString() + "','" + str[0] + "',N'" + str[1] + "',N'" + str[2] + "'," + str[3] + "," + str[4] + "," + int.Parse(str[5]) + ")";
                    SqlCommand cmd = new SqlCommand(strSQL, conn);
                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand("select * from [user]", conn);
                    //建立dataTable
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dataTable);
                    string s_sum = dataTable.Compute("SUM(金額)", "").ToString();
                    label4.Text = s_sum;
                    //設定dataGridView資料來源
                    dataGridView1.DataSource = dataTable;
                    conn.Close();
                }
                
            }
            SqlCommand cmddd = new SqlCommand("select [金額] from [user]", conn);
            //建立dataTable
            
            SqlDataAdapter daaa= new SqlDataAdapter(cmddd);
            
            
            conn.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";

            cn.Open();
            string sql = @"select*from[user]";
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            MessageBox.Show(dataGridView1.Rows.Count.ToString());

            cn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";

            SqlConnection conn = new SqlConnection(strCon);

            conn.Open();

            string strSQL = $"DELETE from[user] where 訂單編號="+textBox1.Text ;
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand("select*from[user]", conn);

            DataTable dataTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dataTable);
            string s_sum = dataTable.Compute("SUM(金額)", "").ToString();
            label4.Text = s_sum;
            dataGridView1.DataSource = dataTable;
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 f = new Form1(tablenum);
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            報表 f = new 報表();

            this.Visible = false;
            f.Visible = true;
        }
    }
}
