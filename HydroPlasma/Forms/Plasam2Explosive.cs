using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HydroPlasma.Forms
{
    public partial class Plasam2Explosive : Form
    {
        public Plasam2Explosive()
        {
            InitializeComponent();
        }

        private void btnCalcMaxPre_Click(object sender, EventArgs e)
        {
            double capacity = double.Parse(this.tbCapacity.Text);
            double capacityNum = double.Parse(this.tbCapacityNum.Text);
            double outputVoltage = double.Parse(this.OutPutVol.Text);
            double probeLen = double.Parse(this.tbProbeLen.Text);
            double energyPerMM = 0.5*(capacityNum* capacity) *(outputVoltage*outputVoltage)*0.24/probeLen;
            double explosiveWeight = 0.0680441647145757*Math.Pow(Math.E, 0.0467657460884651*energyPerMM);
            this.tbExplosiveWeight.Text = explosiveWeight.ToString("0.00");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double maxPressure = 924.83266*Math.Pow(Math.E, -(0.1135/double.Parse(this.tbExplosiveWeight.Text)));
            CalcPressureByExplosive(double.Parse(this.tbExplosiveWeight.Text));
        }
        private void CalcPressureByExplosive(double exlosiveWeight)
        {
            //throw new NotImplementedException();
            //throw new NotImplementedException();
            int ponitNum = 100;
            double[] lenArr = new double[ponitNum];
            for (int i = 0; i < ponitNum; i++)
            {
                lenArr[i] = i*100/(ponitNum - 1);
            }
            double[] pressureArr = new double[ponitNum];
            for (int i = 0; i < ponitNum; i++)
            {
                pressureArr[i] = 576.1743/(1 + Math.Pow(lenArr[i]/2.05233, 0.70396)) - 22.23615;
            }
                //画图
                Series ss = new Series("炸药量" + exlosiveWeight.ToString("0.00") + "g");
                ss.Color = Color.CornflowerBlue;
                ss.Points.DataBindXY(lenArr, pressureArr);
                ss.BorderWidth = 3;
                ss.ChartType = SeriesChartType.Spline;
                this.chartMaxPre.Series.Add(ss);
            
            //修改X坐标轴
            int maxX2 = 100;
            this.chartMaxPre.ChartAreas[0].AxisX.Minimum = 0;
            this.chartMaxPre.ChartAreas[0].AxisX.Maximum = maxX2;
            //修改坐标轴标题
            this.chartMaxPre.ChartAreas[0].AxisX.Title = "距爆炸中心距离 mm";
            this.chartMaxPre.ChartAreas[0].AxisY.Title = "峰值压力 MPa";
            //不显示网格线
            this.chartMaxPre.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            this.chartMaxPre.ChartAreas[0].AxisX.ArrowStyle = AxisArrowStyle.Triangle;
            this.chartMaxPre.ChartAreas[0].AxisY.ArrowStyle = AxisArrowStyle.Triangle;
            // this.chartMaxPre.ChartAreas[0].AxisX.IsMarginVisible = false;
            //坐标轴刻度类型
            TickMark t = new TickMark();
            t.TickMarkStyle = TickMarkStyle.None;
            this.chartMaxPre.ChartAreas[0].AxisX.MajorTickMark = t;
            this.chartMaxPre.ChartAreas[0].AxisY.MajorTickMark = t;
            //this.chartMaxPre.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;

        }

        private void btnSaveImg_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "All files (*.*)|*.*|图片 (*.Png)|*.Png";
            fileDialog.FilterIndex = 2;
            fileDialog.InitialDirectory = Application.StartupPath;
            string fileName = Guid.NewGuid().ToString();
            fileDialog.FileName = fileName;
            if (fileDialog.ShowDialog() == DialogResult.OK && fileDialog.FileName != "")
            {
                fileName = fileDialog.FileName;
            }
            //文件流
            //using (FileStream fs = new FileStream(fileName, FileMode.CreateNew))
            //{
            //    //获得图像
            //    var images = this.chartMaxPre.Images;
            //    Image image = images.FirstOrDefault().Image;
            //    image.Save(fs);
            //}
            //var images = this.chartMaxPre.;
            //Image image = images.FirstOrDefault().Image;
            //image.Save(fileName);
            //MessageBox.Show("图像保存成功");
            try
            {
                this.chartMaxPre.SaveImage(fileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                MessageBox.Show("图像保存成功");
            }
            catch (Exception)
            {
                MessageBox.Show("图像保存失败，请重试");
            }
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            FormUtils.SavePressureData("距爆炸中心距离", this.chartMaxPre);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定要退出吗？", "提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK) ;
            this.Close();
        }
    }
}
