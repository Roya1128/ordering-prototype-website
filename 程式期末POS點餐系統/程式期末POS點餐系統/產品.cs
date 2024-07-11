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
  
    public partial class Form1 : Form
    {
        public string table;
        public string[,] sushi = new string[,] { { "../../Resources/香蔥鮪魚.JPG", "香蔥鮪魚","40" }, { "../../Resources/鮪魚中貫.JPG", "鮪魚中貫","80" }, { "../../Resources/炙烤起司豬五花.JPG", "炙烤起司豬五花","40" },
            { "../../Resources/北海道貝.JPG", "北海道貝","80" }, { "../../Resources/鮭魚肚.JPG", "鮭魚肚","40" }, { "../../Resources/牛五花燒肉.JPG", "牛五花燒肉","40" } };
        public string[,] vice = new string[,] { { "../../Resources/天婦羅烏龍麵.JPG", "天婦羅烏龍麵","130" }, { "../../Resources/牛肉烏龍麵.JPG", "牛肉烏龍麵","130" }, { "../../Resources/豆皮烏龍麵.JPG", "豆皮烏龍麵" ,"90"},
            { "../../Resources/薯條.JPG", "薯條","60" }, { "../../Resources/茶碗蒸.JPG", "茶碗蒸","60" }, { "../../Resources/炸雞.JPG", "炸雞","60" } };
        public string[,] dessert = new string[,] { { "../../Resources/牛奶布丁塔.JPG", "牛奶布丁塔","40" }, {"../../Resources/牛奶冰淇淋.JPG", "牛奶冰淇淋","40" }, {"../../Resources/抹茶冰淇淋.JPG","抹茶冰淇淋","40"}, 
            {"../../Resources/重乳酪起司.JPG", "重乳酪起司","80" },{ "../../Resources/焦糖金磚.JPG", "焦糖金磚","90" }, { "../../Resources/莓果聖誕.JPG", "莓果巧克力聖誕","90" } };
        public string[,] drink = new string[,] { { "../../Resources/柳橙汁.JPG" ,"柳橙汁","60"}, {"../../Resources/蘋果汁.JPG","蘋果汁","60" }, { "../../Resources/啤酒.JPG","啤酒","90" } };
      
        public Form1(string strTextMsg)
        {
            InitializeComponent();
            table = strTextMsg;

        }
        int s = 0;
        int p;
        int t;

        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Text = table;
            timer1.Enabled = true;
            timer1.Interval = 1000;
            //label1.Text = s.ToString();
            timer2.Enabled = true;
            timer2.Interval = 60000;
            label3.Text = t.ToString();
            t = 120;
            label3.Text = "剩餘120分";
            timer2.Start();
            timer3.Enabled = true;
            timer3.Interval = 1000;
            label7.Text = "";

        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
            string combotext = comboBox1.Text;
         
            switch (combotext)
            {
                case "壽司":
                    pictureBox2.Image = Image.FromFile(sushi[0, 0]);
                    pictureBox3.Image = Image.FromFile(sushi[1, 0]);
                    pictureBox4.Image = Image.FromFile(sushi[2, 0]);
                    label8.Text = sushi[0, 1];
                    label9.Text = sushi[1, 1];
                    label10.Text = sushi[2, 1];

                    label11.Text = sushi[1, 2];
                    label12.Text = sushi[2, 2];
                    label13.Text = vice[3, 2];
                            label12.Text = vice[4, 2];
                            label13.Text = vice[5, 2];
                    break;
                case "副餐":
                    pictureBox2.Image = Image.FromFile(vice[0, 0]);
                    pictureBox3.Image = Image.FromFile(vice[1, 0]);
                    pictureBox4.Image = Image.FromFile(vice[2, 0]);
                    label8.Text = vice[0, 1];
                    label9.Text =vice[1, 1];
                    label10.Text = vice[2, 1];
                    label11.Text = vice[0, 2];
                    label12.Text = vice[1, 2];
                    label13.Text = vice[2, 2];
                    label6.Text = "1/2";
                    break;
                case "甜點":
                    pictureBox2.Image = Image.FromFile(dessert[0, 0]);
                    pictureBox3.Image = Image.FromFile(dessert[1, 0]);
                    pictureBox4.Image = Image.FromFile(dessert[2, 0]);
                    label8.Text = dessert[0, 1];
                    label9.Text = dessert[1, 1];
                    label10.Text = dessert[2, 1];
                    label11.Text = dessert[0, 2];
                    label12.Text = dessert[1, 2];
                    label13.Text = dessert[2, 2];
                    label6.Text = "1/2";
                    break;
                case "飲料":
                    pictureBox2.Image = Image.FromFile(drink[0,0]);
                    pictureBox3.Image = Image.FromFile(drink[1,0]);
                    pictureBox4.Image = Image.FromFile(drink[2,0]);
                    label8.Text = drink[0, 1];
                    label9.Text = drink[1, 1];
                    label10.Text = drink[2, 1];
                    label11.Text = drink[0, 2];
                    label12.Text = drink[1, 2];
                    label13.Text = drink[2, 2];
                    label6.Text = "1/1";
                    break;
                default:
                    break;
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
         
            string page = label6.Text;
            string combotext = comboBox1.Text;
            switch (combotext)
            {
                case "壽司":
                    switch (page)
                    {
                        case "1/2":
                            MessageBox.Show("這是第一頁喔", "sorry!");

                            break;
                        case "2/2":

                            pictureBox2.Image = Image.FromFile(sushi[0, 0]);
                            pictureBox3.Image = Image.FromFile(sushi[1, 0]);
                            pictureBox4.Image = Image.FromFile(sushi[2, 0]);
                            label8.Text = sushi[0, 1];
                            label9.Text = sushi[1, 1];
                            label10.Text = sushi[2, 1];
                            label11.Text = sushi[0, 2];
                            label12.Text = sushi[1, 2];
                            label13.Text = sushi[2, 2];
                            label6.Text = "1/2";
                            break;
                        default:
                            break;
                    }
                    break;
                case "副餐":
                    switch (page)
                    {
                        case "1/2":
                            MessageBox.Show("這是第一頁喔", "sorry!");

                            break;
                        case "2/2":
                            pictureBox2.Image = Image.FromFile(vice[0, 0]);
                            pictureBox3.Image = Image.FromFile(vice[1, 0]);
                            pictureBox4.Image = Image.FromFile(vice[2, 0]);
                            label8.Text = vice[0, 1];
                            label9.Text = vice[1, 1];
                            label10.Text = vice[2, 1];
                            label11.Text = vice[0, 2];
                            label12.Text = vice[1, 2];
                            label13.Text = vice[2, 2];
                            label6.Text = "1/2";
                            break;
                        default:
                            break;
                    }
                    break;
                case "甜點":
                    switch (page)
                    {
                        case "1/2":
                            MessageBox.Show("這是第一頁喔", "sorry!");

                            break;
                        case "2/2":
                            pictureBox2.Image = Image.FromFile(dessert[0, 0]);
                            pictureBox3.Image = Image.FromFile(dessert[1, 0]);
                            pictureBox4.Image = Image.FromFile(dessert[2, 0]);
                            label8.Text = dessert[0, 1];
                            label9.Text = dessert[1, 1];
                            label10.Text = dessert[2, 1];
                            label11.Text = dessert[0, 2];
                            label12.Text = dessert[1, 2];
                            label13.Text = dessert[2, 2];
                            label6.Text = "1/2";
                            break;
                        default:
                            break;
                    }
                    break;
                case "飲料":
                    MessageBox.Show("這是第一頁喔", "sorry!");
                    pictureBox2.Image = Image.FromFile(drink[0, 0]);
                    pictureBox3.Image = Image.FromFile(drink[1, 0]);
                    pictureBox4.Image = Image.FromFile(drink[2, 0]);
                    label8.Text = drink[0, 1];
                    label9.Text = drink[1, 1];
                    label10.Text = drink[2, 1];
                    label11.Text = drink[0, 2];
                    label12.Text = drink[1, 2];
                    label13.Text = drink[2, 2];
                    label6.Text = "1/1";
                    break; 
                default:
                    break;
            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
       
            string page = label6.Text;
            string combotext = comboBox1.Text;
            switch (combotext)
            {
                case "壽司":
                    switch (page)
                    {
                        case "1/2":
                            pictureBox2.Image = Image.FromFile(sushi[3, 0]);
                            pictureBox3.Image = Image.FromFile(sushi[4, 0]);
                            pictureBox4.Image = Image.FromFile(sushi[5, 0]);
                            label8.Text = sushi[3, 1];
                            label9.Text = sushi[4, 1];
                            label10.Text = sushi[5, 1];
                            label11.Text = sushi[3, 2];
                            label12.Text = sushi[4, 2];
                            label13.Text = sushi[5, 2];
                            label6.Text = "2/2";
                            break;
                        case "2/2":
                            MessageBox.Show("這是最後一頁喔", "sorry!");
                            break;
                        default:
                            break;
                    }
                    break;
                case "副餐":
                    switch (page)
                    {
                        case "1/2":
                            pictureBox2.Image = Image.FromFile(vice[3, 0]);
                            pictureBox3.Image = Image.FromFile(vice[4, 0]);
                            pictureBox4.Image = Image.FromFile(vice[5, 0]);
                            label8.Text = vice[3, 1];
                            label9.Text = vice[4, 1];
                            label10.Text = vice[5, 1];
                            label11.Text = vice[3, 2];
                            label12.Text = vice[4, 2];
                            label13.Text = vice[5, 2];
                            label6.Text = "2/2";
                            break;
                        case "2/2":
                            MessageBox.Show("這是最後一頁喔", "sorry!");
                            break;
                        default:
                            break;
                    }
                    break;
                case "甜點":
                    switch (page)
                    {
                        case "1/2":
                            pictureBox2.Image = Image.FromFile(dessert[3, 0]);
                            pictureBox3.Image = Image.FromFile(dessert[4, 0]);
                            pictureBox4.Image = Image.FromFile(dessert[5, 0]);
                            label8.Text = dessert[3, 1];
                            label9.Text = dessert[4, 1];
                            label10.Text = dessert[5, 1];
                            label11.Text = dessert[3, 2];
                            label12.Text = dessert[4, 2];
                            label13.Text = dessert[5, 2];
                            label6.Text = "2/2";
                            break;
                        case "2/2":
                            MessageBox.Show("這是最後一頁喔", "sorry!");
                            break;
                        default:
                            break;
                    }
                    break;
                case "飲料":
                    MessageBox.Show("這是最後一頁喔", "sorry!");
                 
                    break;
                default:
                    break;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] list = null;
            string table = label5.Text;
            結帳 f = new 結帳(list,table);
            
            this.Hide();
            f.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            switch (label8.Text) {
                case "香蔥鮪魚":
                    string[] name = { label5.Text, comboBox1.Text, sushi[0, 0], sushi[0, 1], sushi[0, 2] };
                    確定點餐 f = new 確定點餐(name);
                    this.Visible = false;
                    f.Visible = true;
                    break;
                case "北海道貝":
                    string[] name1 = { label5.Text, comboBox1.Text, sushi[3, 0], sushi[3, 1], sushi[3, 2] };
                    確定點餐 f1 = new 確定點餐(name1);
                    this.Visible = false;
                    f1.Visible = true;
                    break;
                case "天婦羅烏龍麵":
                    string[] name2 = { label5.Text, comboBox1.Text, vice[0, 0], vice[0, 1], vice[0, 2] };
                    確定點餐 f2 = new 確定點餐(name2);
                    this.Visible = false;
                    f2.Visible = true;
                    break;
                case "薯條":
                    string[] name3 = { label5.Text, comboBox1.Text, vice[3, 0], vice[3, 1] , vice[3, 2] };
                    確定點餐 f3 = new 確定點餐(name3);
                    this.Visible = false;
                    f3.Visible = true;
                    break;
                case "牛奶布丁塔":
                    string[] name4 = { label5.Text, comboBox1.Text, dessert[0, 0], dessert[0, 1], dessert[0, 2] };
                    確定點餐 f4 = new 確定點餐(name4);
                    this.Visible = false;
                    f4.Visible = true;
                    break;
                case "重乳酪起司":
                    string[] name5 = { label5.Text, comboBox1.Text, dessert[3, 0], dessert[3, 1], dessert[3, 2] };
                    確定點餐 f5 = new 確定點餐(name5);
                    this.Visible = false;
                    f5.Visible = true;
                    break;
                case "柳橙汁":
                    string[] name6 = { label5.Text, comboBox1.Text, drink[0, 0], drink[0, 1], drink[0, 2] };
                    確定點餐 f6 = new 確定點餐(name6);
                    this.Visible = false;
                    f6.Visible = true;
                    break;

            }
          
            

        }

       

        private void label7_Click(object sender, EventArgs e)
        {

        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            s++;
            //label1.Text = s.ToString();
            if (s % 3 == 0)
            {
                string[] imgName = { "../../Resources/廣告.JPG", "../../Resources/廣告2.JPG",
                    "../../Resources/廣告3.JPG", "../../Resources/廣告4.JPG",
                    "../../Resources/廣告5.JPG" };

                if (p == 5)
                {
                    p = 0;
                }
                pictureBox1.Image = Image.FromFile(imgName[p]);

                p++;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (t > 0)
            {
                t = t - 1;
                label3.Text = "剩餘" + t + " 分";
            }
            else
            {

                timer2.Stop();
                label3.Text = "Time's up!";
                MessageBox.Show("時間到不能再進行點餐囉", "Sorry!");

                timer2.Enabled = true;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            switch (label9.Text)
            {
                case "鮪魚中貫":
                    string[] name = { label5.Text, comboBox1.Text, sushi[1, 0], sushi[1, 1], sushi[1, 2] };
                    確定點餐 f = new 確定點餐(name);
                    this.Visible = false;
                    f.Visible = true;
                    break;
                case "鮭魚肚":
                    string[] name1 = { label5.Text, comboBox1.Text, sushi[4, 0], sushi[4, 1] , sushi[4, 2] };
                    確定點餐 f1 = new 確定點餐(name1);
                    this.Visible = false;
                    f1.Visible = true;
                    break;
                case "牛肉烏龍麵":
                    string[] name2 = { label5.Text, comboBox1.Text, vice[1, 0], vice[1, 1], vice[1, 2] };
                    確定點餐 f2 = new 確定點餐(name2);
                    this.Visible = false;
                    f2.Visible = true;
                    break;
                case "茶碗蒸":
                    string[] name3 = { label5.Text, comboBox1.Text, vice[4, 0], vice[4, 1], vice[4, 2] };
                    確定點餐 f3 = new 確定點餐(name3);
                    this.Visible = false;
                    f3.Visible = true;
                    break;
                case "牛奶冰淇淋":
                    string[] name4 = { label5.Text, comboBox1.Text, dessert[1, 0], dessert[1, 1], dessert[1, 2] };
                    確定點餐 f4 = new 確定點餐(name4);
                    this.Visible = false;
                    f4.Visible = true;
                    break;
                case "焦糖金磚":
                    string[] name5 = { label5.Text, comboBox1.Text, dessert[4, 0], dessert[4, 1], dessert[4, 2] };
                    確定點餐 f5 = new 確定點餐(name5);
                    this.Visible = false;
                    f5.Visible = true;
                    break;
                case "蘋果汁":
                    string[] name6 = { label5.Text, comboBox1.Text, drink[1, 0], drink[1, 1], drink[1, 2] };
                    確定點餐 f6 = new 確定點餐(name6);
                    this.Visible = false;
                    f6.Visible = true;
                    break;

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            switch (label10.Text)
            {
                case "炙烤起司豬五花":
                    string[] name = { label5.Text, comboBox1.Text, sushi[2, 0], sushi[2, 1], sushi[2, 2] };
                    確定點餐 f = new 確定點餐(name);
                    this.Visible = false;
                    f.Visible = true;
                    break;
                case "牛五花燒肉":
                    string[] name1 = { label5.Text, comboBox1.Text, sushi[5, 0], sushi[5, 1], sushi[5, 2] };
                    確定點餐 f1 = new 確定點餐(name1);
                    this.Visible = false;
                    f1.Visible = true;
                    break;
                case "豆皮烏龍麵":
                    string[] name2 = { label5.Text, comboBox1.Text, vice[2, 0], vice[2, 1], vice[2, 2] };
                    確定點餐 f2 = new 確定點餐(name2);
                    this.Visible = false;
                    f2.Visible = true;
                    break;
                case "炸雞":
                    string[] name3 = { label5.Text, comboBox1.Text, vice[5, 0], vice[5, 1], vice[5, 2] };
                    確定點餐 f3 = new 確定點餐(name3);
                    this.Visible = false;
                    f3.Visible = true;
                    break;
                case "抹茶冰淇淋":
                    string[] name4 = { label5.Text, comboBox1.Text, dessert[2, 0], dessert[2, 1], dessert[2, 2] };
                    確定點餐 f4 = new 確定點餐(name4);
                    this.Visible = false;
                    f4.Visible = true;
                    break;
                case "莓果巧克力聖誕":
                    string[] name5 = { label5.Text, comboBox1.Text, dessert[5, 0], dessert[5, 1], dessert[5, 2] };
                    確定點餐 f5 = new 確定點餐(name5);
                    this.Visible = false;
                    f5.Visible = true;
                    break;
                case "啤酒":
                    string[] name6 = { label5.Text, comboBox1.Text, drink[2, 0], drink[2, 1] , drink[2, 2] };
                    確定點餐 f6 = new 確定點餐(name6);
                    this.Visible = false;
                    f6.Visible = true;
                    break;

            }
        }
    }
}
