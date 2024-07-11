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
    public partial class 報表 : Form
    {
        public 報表()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'Database1DataSet4.user' 資料表。您可以視需要進行移動或移除。
            this.userTableAdapter.Fill(this.Database1DataSet4.user);

            this.reportViewer1.RefreshReport();
        }
    }
}
