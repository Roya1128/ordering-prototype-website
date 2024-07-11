
namespace 程式期末POS點餐系統
{
    partial class 結帳
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet7 = new 程式期末POS點餐系統.Database1DataSet7();
            this.userBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet4 = new 程式期末POS點餐系統.Database1DataSet4();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new 程式期末POS點餐系統.Database1DataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.userTableAdapter = new 程式期末POS點餐系統.Database1DataSetTableAdapters.userTableAdapter();
            this.userTableAdapter1 = new 程式期末POS點餐系統.Database1DataSet1TableAdapters.userTableAdapter();
            this.userTableAdapter2 = new 程式期末POS點餐系統.Database1DataSet4TableAdapters.userTableAdapter();
            this.點餐BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet5 = new 程式期末POS點餐系統.Database1DataSet5();
            this.userBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter3 = new 程式期末POS點餐系統.Database1DataSet5TableAdapters.userTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.database1DataSet6 = new 程式期末POS點餐系統.Database1DataSet6();
            this.userBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter4 = new 程式期末POS點餐系統.Database1DataSet6TableAdapters.userTableAdapter();
            this.userTableAdapter5 = new 程式期末POS點餐系統.Database1DataSet7TableAdapters.userTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.database1DataSet8 = new 程式期末POS點餐系統.Database1DataSet8();
            this.userBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter6 = new 程式期末POS點餐系統.Database1DataSet8TableAdapters.userTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.訂單編號 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.桌號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.產品名稱 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.點餐BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.訂單編號,
            this.桌號DataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.產品名稱,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.DataSource = this.userBindingSource5;
            this.dataGridView1.Location = new System.Drawing.Point(11, 68);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(889, 285);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.VirtualMode = true;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // userBindingSource4
            // 
            this.userBindingSource4.DataMember = "user";
            this.userBindingSource4.DataSource = this.database1DataSet7;
            // 
            // database1DataSet7
            // 
            this.database1DataSet7.DataSetName = "Database1DataSet7";
            this.database1DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource1
            // 
            this.userBindingSource1.DataMember = "user";
            this.userBindingSource1.DataSource = this.database1DataSet4;
            // 
            // database1DataSet4
            // 
            this.database1DataSet4.DataSetName = "Database1DataSet4";
            this.database1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(805, 381);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "結帳";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(28, 376);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(299, 377);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 30);
            this.button3.TabIndex = 6;
            this.button3.Text = "刪除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // userTableAdapter1
            // 
            this.userTableAdapter1.ClearBeforeFill = true;
            // 
            // userTableAdapter2
            // 
            this.userTableAdapter2.ClearBeforeFill = true;
            // 
            // 點餐BindingSource
            // 
            this.點餐BindingSource.DataMember = "點餐";
            // 
            // database1DataSet5
            // 
            this.database1DataSet5.DataSetName = "Database1DataSet5";
            this.database1DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource2
            // 
            this.userBindingSource2.DataMember = "user";
            this.userBindingSource2.DataSource = this.database1DataSet5;
            // 
            // userTableAdapter3
            // 
            this.userTableAdapter3.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(614, 382);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 27);
            this.label3.TabIndex = 13;
            this.label3.Text = "總金額";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(711, 381);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 27);
            this.label4.TabIndex = 14;
            this.label4.Text = "金額";
            // 
            // database1DataSet6
            // 
            this.database1DataSet6.DataSetName = "Database1DataSet6";
            this.database1DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource3
            // 
            this.userBindingSource3.DataMember = "user";
            this.userBindingSource3.DataSource = this.database1DataSet6;
            // 
            // userTableAdapter4
            // 
            this.userTableAdapter4.ClearBeforeFill = true;
            // 
            // userTableAdapter5
            // 
            this.userTableAdapter5.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 381);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(123, 378);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 27);
            this.label5.TabIndex = 16;
            this.label5.Text = "編號";
            // 
            // database1DataSet8
            // 
            this.database1DataSet8.DataSetName = "Database1DataSet8";
            this.database1DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource5
            // 
            this.userBindingSource5.DataMember = "user";
            this.userBindingSource5.DataSource = this.database1DataSet8;
            // 
            // userTableAdapter6
            // 
            this.userTableAdapter6.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "訂購清單";
            // 
            // 訂單編號
            // 
            this.訂單編號.DataPropertyName = "訂單編號";
            this.訂單編號.HeaderText = "訂單編號";
            this.訂單編號.Name = "訂單編號";
            // 
            // 桌號DataGridViewTextBoxColumn
            // 
            this.桌號DataGridViewTextBoxColumn.DataPropertyName = "桌號";
            this.桌號DataGridViewTextBoxColumn.HeaderText = "桌號";
            this.桌號DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.桌號DataGridViewTextBoxColumn.Name = "桌號DataGridViewTextBoxColumn";
            this.桌號DataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "產品類別";
            this.dataGridViewTextBoxColumn1.HeaderText = "產品類別";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // 產品名稱
            // 
            this.產品名稱.DataPropertyName = "產品名稱";
            this.產品名稱.HeaderText = "產品名稱";
            this.產品名稱.MinimumWidth = 6;
            this.產品名稱.Name = "產品名稱";
            this.產品名稱.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "單價";
            this.dataGridViewTextBoxColumn2.HeaderText = "單價";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "數量";
            this.dataGridViewTextBoxColumn3.HeaderText = "數量";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "金額";
            this.dataGridViewTextBoxColumn4.HeaderText = "金額";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // 結帳
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 430);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "結帳";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.結帳_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.點餐BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
      
        private System.Windows.Forms.BindingSource 點餐BindingSource;
     
        private System.Windows.Forms.DataGridViewTextBoxColumn 產品類別DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 產品名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 單價DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 數量DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private Database1DataSetTableAdapters.userTableAdapter userTableAdapter;
        private Database1DataSet1TableAdapters.userTableAdapter userTableAdapter1;
        private Database1DataSet4 database1DataSet4;
        private System.Windows.Forms.BindingSource userBindingSource1;
        private Database1DataSet4TableAdapters.userTableAdapter userTableAdapter2;
        private Database1DataSet5 database1DataSet5;
        private System.Windows.Forms.BindingSource userBindingSource2;
        private Database1DataSet5TableAdapters.userTableAdapter userTableAdapter3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Database1DataSet6 database1DataSet6;
        private System.Windows.Forms.BindingSource userBindingSource3;
        private Database1DataSet6TableAdapters.userTableAdapter userTableAdapter4;
        private Database1DataSet7 database1DataSet7;
        private System.Windows.Forms.BindingSource userBindingSource4;
        private Database1DataSet7TableAdapters.userTableAdapter userTableAdapter5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private Database1DataSet8 database1DataSet8;
        private System.Windows.Forms.BindingSource userBindingSource5;
        private Database1DataSet8TableAdapters.userTableAdapter userTableAdapter6;
        private System.Windows.Forms.DataGridViewTextBoxColumn 訂單編號;
        private System.Windows.Forms.DataGridViewTextBoxColumn 桌號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 產品名稱;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label1;
    }
}