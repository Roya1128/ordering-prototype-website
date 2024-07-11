using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 程式期末POS點餐系統
{
    public partial class 桌號選擇 : Form
    {
        public string s ;
        public 桌號選擇()
        {
            InitializeComponent();
            string list = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXZ0123456789";
            string code = "";
            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {
                code += list[random.Next(0, list.Length)];
            }
            label3.Text = code;
            
        }


        private void 桌號選擇_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string code = label3.Text;
            



            if (code == textBox1.Text && comboBox1.Text != "")
            {
                MessageBox.Show("歡迎光臨，藏壽司");
                s = comboBox1.Text;
                主畫面 f = new 主畫面(s);

                this.Visible = false;
                f.Visible = true;

            }
            else
            {
                MessageBox.Show("桌號不能為空或驗證碼有誤!", "Login Fail!");
                string list = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXZ0123456789";
                code = "";
                Random random = new Random();
                for (int i = 0; i < 4; i++)
                {
                    code += list[random.Next(0, list.Length)];

                }


            }
            label3.Text = code;
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBox1.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
