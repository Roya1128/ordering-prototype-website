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
    public partial class 確定點餐 : Form
    {
        public string[] str={""};
        public 確定點餐(string[] s)
        {
            InitializeComponent();
            str = s;
        }
      
        private void 確定點餐_Load_1(object sender, EventArgs e)
        {   label2.Text = str[3];
            label4.Text = str[4];
           pictureBox1.Image= Image.FromFile(str[2]);
            // TODO: 這行程式碼會將資料載入 'database1DataSet3.user' 資料表。您可以視需要進行移動或移除。
            this.userTableAdapter1.Fill(this.database1DataSet3.user);
            // TODO: 這行程式碼會將資料載入 'database1DataSet.user' 資料表。您可以視需要進行移動或移除。
            int a;
            decimal b;
            a = int.Parse(label4.Text);
            b = numericUpDown1.Value;
            label8.Text = (a * b).ToString();
            //b = int.Parse(numericUpDown1.Value);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string[] name = { str[0], str[1], str[3], label4.Text, numericUpDown1.Value.ToString() ,label8.Text};
            結帳 f = new 結帳(name,str[0]);
            this.Visible = false;
            f.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1(str[0]);
            this.Visible = false;
            f.Visible = true;
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int a;
            decimal b;
            a = int.Parse(label4.Text);
            b = numericUpDown1.Value;
            label8.Text = (a * b).ToString();
        }
    }
}
