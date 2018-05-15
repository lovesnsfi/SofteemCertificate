using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NPOI.ReadExcel;
using System.IO;
using System.Drawing.Drawing2D;
using System.Threading;

namespace Softeem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        //excel文件
        public string excelFile = string.Empty;
        //结业证图片模版
        public string picUrl = string.Empty;
        //输出文件夹
        public string outPutPath = string.Empty;
        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Excel文件(*.xls,*.xlsx)|*.xls;*.xlsx";
            if (of.ShowDialog()==DialogResult.OK)
            {
                this.txtExcelFilePath.Text = this.excelFile = of.FileName;
                DataTable dt = (new ExcelHelper(this.excelFile)).ExcelToDataTable("",true);
                this.dataGridView1.DataSource = dt;
            }
        }

        //选择输出文件夹
        private void btnSelectOut_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择生成结业证所在文件夹";
            if (dialog.ShowDialog()==DialogResult.OK)
            {
                this.txtOutPutPath.Text =this.outPutPath = dialog.SelectedPath;
            }
        }

        private void btnSelectPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "图片文件(*.bmp,*.jpg,*.gif,*.jpeg,*.png)|*.bmp;*.jpg;*.gif;*.jpeg,*.png";
            if (of.ShowDialog() == DialogResult.OK)
            {
                this.txtPicUrl.Text = this.picUrl = of.FileName;
            }
        }

        //开始生成
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.outPutPath)&&!string.IsNullOrEmpty(this.excelFile)&&!string.IsNullOrEmpty(this.picUrl))
            {
                ExcelHelper excelHelper = new ExcelHelper(this.excelFile);
                DataTable dt = excelHelper.ExcelToDataTable("", true);
                if (dt.Rows.Count <= 0) 
                {
                    MessageBox.Show("没有数据");
                }
                else
                {
                    DrawPic(dt);
                }
                
            }
            else
            {
                MessageBox.Show("请将参数填写完整以后再进行");
            }

        }

        public void DrawPic(DataTable dt)
        {
            Thread th = new Thread(new ThreadStart(() =>
            {
                this.Invoke((Action)(() =>
                {
                    this.saveProgressBar.Maximum = dt.Rows.Count;
                    this.btnStart.Enabled = false;
                }));
                int count = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    using (FileStream fs = new FileStream(this.picUrl, FileMode.Open, FileAccess.Read))
                    {
                        Bitmap bmp = new Bitmap(Image.FromStream(fs));
                        Graphics g = Graphics.FromImage(bmp);
                        //定义绘画的字体
                        Font f = new Font(new FontFamily("宋体"), 32, FontStyle.Bold);
                        //定义绘画区域大小
                        Size drawSize = new Size(bmp.Width, bmp.Height);
                        //定义排版格式
                        StringFormat sf = new StringFormat();
                        sf.Alignment = StringAlignment.Center;  //左右居中
                        //定义绘画区域矩形
                        Rectangle rectName = new Rectangle(new Point(0, 550), drawSize);
                        //绘制姓名
                        g.DrawString(dt.Rows[i]["姓名"].ToString(), f, new SolidBrush(Color.Black), rectName, sf);
                        Rectangle rectPingYin = new Rectangle(new Point(0, 610), drawSize);

                        //绘制拼音
                        Font pinyinFont = new Font(new FontFamily("宋体"), 28, FontStyle.Bold);
                        g.DrawString(PingYinHelper.ConvertToAllSpell(dt.Rows[i]["姓名"].ToString()), pinyinFont, new SolidBrush(Color.Black), rectPingYin, sf);

                        //绘制 培训方向
                        Font f_fangxinag = new Font(new FontFamily("宋体"), 32, FontStyle.Bold);
                        Rectangle fangXingRect = new Rectangle(new Point(299, 820), new Size(189, 50));
                        g.DrawString(dt.Rows[i]["培训方向"].ToString(), f_fangxinag, new SolidBrush(Color.Black), fangXingRect, sf);


                        //绘制 合格证编号
                        //78199460901170225
                        StringFormat sf_left = new StringFormat();
                        sf_left.Alignment = StringAlignment.Near;
                        Font bianHaoFont = new Font(new FontFamily("宋体"), 26, FontStyle.Bold);
                        Rectangle bianHaoRect = new Rectangle(new Point(585, 1010), new Size(350, 50));
                        g.DrawString(dt.Rows[i]["合格证编号"].ToString(), bianHaoFont, new SolidBrush(Color.Black), bianHaoRect, sf_left);

                        //绘制身份证号
                        //42098418909171814
                        Font cardNOFont = new Font(new FontFamily("宋体"), 26, FontStyle.Bold);
                        Rectangle cardNORect = new Rectangle(new Point(585, 1070), new Size(350, 50));
                        g.DrawString(dt.Rows[i]["身份证号"].ToString(), cardNOFont, new SolidBrush(Color.Black), cardNORect, sf_left);

                        //绘制日期
                        DateTime d = DateTime.Parse(dt.Rows[0]["培训结束时间"].ToString());
                        string time = formatDate(d);
                        Font dateFont = new Font(new FontFamily("宋体"), 26, FontStyle.Bold);
                        Rectangle dateRect = new Rectangle(new Point(585, 1130), new Size(350, 50));
                        g.DrawString(time, dateFont, new SolidBrush(Color.Black), dateRect, sf_left);
                        //保存图片
                        bmp.Save(this.outPutPath + @"\" + dt.Rows[i]["姓名"].ToString() + ".png");
                        fs.Close();
                        this.Invoke((Action)(() => {
                            this.saveProgressBar.Value = i + 1;   
                        }));
                        count++;
                    }
                }
                this.Invoke((Action)(() =>
                {
                    this.btnStart.Enabled = true;
                }));
                MessageBox.Show("生成完成,共生成" + count.ToString() + "张证书");                
            }));

            th.IsBackground = true;
            th.Start();
            
        }

        
        //预览
    
        private void picBoxView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.picBoxView.Image!=null)
            {
                PicViewForm frm = new PicViewForm(this.picBoxView.Image);
                frm.ShowDialog();
            }
        }

        //窗体加载
        public Dictionary<int,string> MonthDic { get; set; }
        private void MainForm_Load(object sender, EventArgs e)
        {
            MonthDic = new Dictionary<int, string>();
            MonthDic.Add(1, "January");
            MonthDic.Add(2, "February");
            MonthDic.Add(3, "March");
            MonthDic.Add(4, "April");
            MonthDic.Add(5, "May");
            MonthDic.Add(6, "June");
            MonthDic.Add(7, "July");
            MonthDic.Add(8, "August");
            MonthDic.Add(9, "September");
            MonthDic.Add(10, "October");
            MonthDic.Add(11, "November");
            MonthDic.Add(12, "December");
        }

        //格式化日期
        public string formatDate(DateTime time)
        {
            string month = MonthDic[time.Month];
            string day = time.Day.ToString("00");
            string year = time.Year.ToString();
            return month + " " + day + "." + year;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!string.IsNullOrEmpty(this.outPutPath)&&!string.IsNullOrEmpty(this.excelFile)&&!string.IsNullOrEmpty(this.picUrl))
            {

                int i = e.RowIndex;
                DataTable dt = this.dataGridView1.DataSource as DataTable;
                using (FileStream fs = new FileStream(this.picUrl, FileMode.Open, FileAccess.Read))
                {
                    Bitmap bmp = new Bitmap(Image.FromStream(fs));
                    Graphics g = Graphics.FromImage(bmp);
                    //定义绘画的字体
                    Font f = new Font(new FontFamily("宋体"), 32, FontStyle.Bold);
                    //定义绘画区域大小
                    Size drawSize = new Size(bmp.Width, bmp.Height);
                    //定义排版格式
                    StringFormat sf = new StringFormat();
                    sf.Alignment = StringAlignment.Center;  //左右居中
                    //定义绘画区域矩形
                    Rectangle rectName = new Rectangle(new Point(0, 550), drawSize);
                    //绘制姓名
                    g.DrawString(dt.Rows[i]["姓名"].ToString(), f, new SolidBrush(Color.Black), rectName, sf);
                    Rectangle rectPingYin = new Rectangle(new Point(0, 610), drawSize);

                    //绘制拼音
                    Font pinyinFont = new Font(new FontFamily("宋体"), 28, FontStyle.Bold);
                    g.DrawString(PingYinHelper.ConvertToAllSpell(dt.Rows[i]["姓名"].ToString()), pinyinFont, new SolidBrush(Color.Black), rectPingYin, sf);

                    //绘制 培训方向
                    Font f_fangxinag = new Font(new FontFamily("宋体"), 32, FontStyle.Bold);
                    Rectangle fangXingRect = new Rectangle(new Point(299, 820), new Size(189, 50));
                    g.DrawString(dt.Rows[i]["培训方向"].ToString(), f_fangxinag, new SolidBrush(Color.Black), fangXingRect, sf);


                    //绘制 合格证编号
                    //78199460901170225
                    StringFormat sf_left = new StringFormat();
                    sf_left.Alignment = StringAlignment.Near;
                    Font bianHaoFont = new Font(new FontFamily("宋体"), 26, FontStyle.Bold);
                    Rectangle bianHaoRect = new Rectangle(new Point(585, 1010), new Size(350, 50));
                    g.DrawString(dt.Rows[i]["合格证编号"].ToString(), bianHaoFont, new SolidBrush(Color.Black), bianHaoRect, sf_left);

                    //绘制身份证号
                    //42098418909171814
                    Font cardNOFont = new Font(new FontFamily("宋体"), 26, FontStyle.Bold);
                    Rectangle cardNORect = new Rectangle(new Point(585, 1070), new Size(350, 50));
                    g.DrawString(dt.Rows[i]["身份证号"].ToString(), cardNOFont, new SolidBrush(Color.Black), cardNORect, sf_left);

                    //绘制日期
                    DateTime d = DateTime.Parse(dt.Rows[0]["培训结束时间"].ToString());
                    string time = formatDate(d);
                    Font dateFont = new Font(new FontFamily("宋体"), 26, FontStyle.Bold);
                    Rectangle dateRect = new Rectangle(new Point(585, 1130), new Size(350, 50));
                    g.DrawString(time, dateFont, new SolidBrush(Color.Black), dateRect, sf_left);
                    //预览图片
                    this.picBoxView.Image = bmp;
                    fs.Close();
                }
            }
        }

    }
}
