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
    public partial class 主畫面 : Form
    {
        public string table;
        
        public 主畫面(string strTextMsg)
        {
            InitializeComponent();
            table = strTextMsg;
            
        }

       

        Random r = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
           
            //主畫面 f = new 主畫面();

            //f.Show();

            ////this.Close();

          
          

        }

        private void label2_Click(object sender, EventArgs e)
        {   
            Form1 f = new Form1(table);

            this.Visible = false;
            f.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
         Form1 f = new Form1 (table);

              this.Visible = false;
               f.Visible = true;
        }
    }
}

