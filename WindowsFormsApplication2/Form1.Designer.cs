namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.accessDataSet = new WindowsFormsApplication2.accessDataSet();
            this.tbGradeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_GradeTableAdapter = new WindowsFormsApplication2.accessDataSetTableAdapters.tb_GradeTableAdapter();
            this.btn2txt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.accessDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGradeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // accessDataSet
            // 
            this.accessDataSet.DataSetName = "accessDataSet";
            this.accessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbGradeBindingSource
            // 
            this.tbGradeBindingSource.DataMember = "tb_Grade";
            this.tbGradeBindingSource.DataSource = this.accessDataSet;
            // 
            // tb_GradeTableAdapter
            // 
            this.tb_GradeTableAdapter.ClearBeforeFill = true;
            // 
            // btn2txt
            // 
            this.btn2txt.Location = new System.Drawing.Point(136, 282);
            this.btn2txt.Name = "btn2txt";
            this.btn2txt.Size = new System.Drawing.Size(75, 23);
            this.btn2txt.TabIndex = 1;
            this.btn2txt.Text = "导出到TXT";
            this.btn2txt.UseVisualStyleBackColor = true;
            this.btn2txt.Click += new System.EventHandler(this.btn2txt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(449, 246);
            this.dataGridView1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(478, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(120, 246);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 335);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn2txt);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accessDataSet, "tb_Grade.name", true));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accessDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGradeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private accessDataSet accessDataSet;
        private System.Windows.Forms.BindingSource tbGradeBindingSource;
        private accessDataSetTableAdapters.tb_GradeTableAdapter tb_GradeTableAdapter;
        private System.Windows.Forms.Button btn2txt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

