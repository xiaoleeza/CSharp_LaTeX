using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        //全局变量,文件全路径
        private string stFilePath = string.Empty;
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        string str_connection = "SERVER=127.0.0.1,8829;DATABASE=uestc;UID=sa;PWD=593106";

        public Form1()
        {
            InitializeComponent();
        }

        //订单数据表Orders,数据查询语句
        string str_select = "select * from tiku831 order by pbNo";

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“accessDataSet.tb_Grade”中。您可以根据需要移动或删除它。
            this.tb_GradeTableAdapter.Fill(this.accessDataSet.tb_Grade);

        }

        /// <summary>
        /// 导出数据到txt文件.<br></br>
        /// 2009-04-24 YJ 定义函数.<br></br>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btn2txt_Click(object sender, EventArgs e)
        {
            //此处的文本文件在工程下Bin的程序集目录下
            stFilePath = Application.StartupPath.Trim() + "\\students" + DateTime.Now.ToString("yyyy年MM月dd日hh时mm分ss秒") + ".tex";
            StreamWriter swStream;
            if (File.Exists(stFilePath))
            {
                swStream = new StreamWriter(stFilePath);
            }
            else
            {
                swStream = File.CreateText(stFilePath);
            }

            swStream.Write("% !Mode:: \"TeX:UTF-8\"\r\n");

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string _strTemp = "\\newproblem{" + ds.Tables[0].Rows[i][0].ToString().Substring(4) + "}{" + ds.Tables[0].Rows[i][3].ToString() + "\r\n}" + "{\r\n" + ds.Tables[0].Rows[i][4].ToString() + "\r\n}\r\n\r\n";
                swStream.Write(_strTemp);
            }
            //关闭流,释放资源
            swStream.Flush();
            swStream.Close();
            //导入Txt文件后,自动打开文件
            Process.Start("notepad++.exe", stFilePath);
 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                //初始化清空数据集ds
                ds.Clear();
                con = new SqlConnection(str_connection);
                //打开数据连接
                con.Open();
                da = new SqlDataAdapter(str_select, con);
                //填充数据集到ds
                da.Fill(ds);
                //绑定数据到DataGridView1
                this.dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
