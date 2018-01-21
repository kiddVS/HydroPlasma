using HydroPlasma.Model;
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
    public partial class PressureFallForm : Form
    {
        public PressureFallForm()
        {
            InitializeComponent();
        }

        private void btnCalcShuaiJian_Click(object sender, EventArgs e)
        {
           
            //初始化数据
            WaveShuaiJianModel model = InicialModel();
            //开始画图
            CalcShuaiJianRule(model);
        }

        private void CalcShuaiJianRule(WaveShuaiJianModel model)
        {
            //点的数量，先写死 20 个
            int pointNum = 20;
            //每一条线
            this.chartMaxPre.Series.Clear();
            double maxX = 0;
            for (int i = 0; i < model.LineNum; i++)
            {            
               
                //当前线下的能量
                double currentEnergy = model.CapacityEnergy;
                //当前线下的电极间距
                double currentProbeLen = model.ProbeMinLength + i * (model.ProbeMaxLength - model.ProbeMinLength) / (model.LineNum - 1);
                //当前线下的峰值压力，效率先写死等于0.24，以后再改吧--！
                double maxPressure= model.ComplexFuncBeita * 100 * Math.Sqrt(currentEnergy * 0.24 / (currentProbeLen / 10)) / 4;
                //x坐标
                double[] lenArr = new double[pointNum];
                for (int j = 0; j < lenArr.Length; j++)
                {
                    lenArr[j] = model.MinLen + j * (model.MaxLen - model.MinLen) / (pointNum - 1);
                }
                //计算最大距离
                maxX = lenArr[pointNum - 1] > maxX ? lenArr[pointNum - 1] : maxX;
                double[] pressureArr = new double[pointNum];
                //计算y坐标
                for (int k = 0; k < pressureArr.Length; k++)
                {
                    pressureArr[k] =maxPressure*Math.Pow(Math.E,(-model.ShuaJianConst*lenArr[k]*0.001/model.WaveSpeed));
                }
                //画图
                Series ss = new Series("电极间距" + (int)currentProbeLen + "mm");
                ss.Points.DataBindXY(lenArr, pressureArr);
                ss.BorderWidth = 3;
                ss.ChartType = SeriesChartType.Spline;
                this.chartMaxPre.Series.Add(ss);
            }
            //修改X坐标轴
            int maxX2 = ((int)maxX / 10 + 1) * 10;
            this.chartMaxPre.ChartAreas[0].AxisX.Minimum = 0;
            this.chartMaxPre.ChartAreas[0].AxisX.Maximum = maxX2;
            //修改坐标轴标题
            this.chartMaxPre.ChartAreas[0].AxisX.Title = "距离爆炸中心距离 mm";
            this.chartMaxPre.ChartAreas[0].AxisY.Title = "压力 MPa";
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

        private WaveShuaiJianModel InicialModel()
        {
            //throw new NotImplementedException();
            WaveShuaiJianModel model = new WaveShuaiJianModel()
            {
                BianYaEfficient = double.Parse(this.tbBianYaEfficient.Text),
                CapacityEnergy = double.Parse(this.tbCapacityEnergy.Text),
                ComplexFuncBeita = double.Parse(this.tbComplexFuncBeita.Text),
                Density = double.Parse(this.tbDensity.Text),
                Ele2WaveEfficient = double.Parse(this.tbEle2WaveEfficient.Text),
                LineNum = int.Parse(this.tbLineNum.Text),
                MaxLen = double.Parse(this.tbMaxLen.Text),
                MinLen = double.Parse(this.tbMinLen.Text),
                ProbeMaxLength = double.Parse(this.tbMaxProbeLength.Text),
                ProbeMinLength = double.Parse(this.tbMinProbeLength.Text),
                PulseUptime = double.Parse(this.tbPulseUpTime.Text),
                PulseWidth = double.Parse(this.tbPulseWidth.Text),
                ShuaJianConst = double.Parse(this.tbShuaiJianCons.Text),
                ShuDianEfficient = double.Parse(this.tbShuDianEfficient.Text),
                WaveSpeed = double.Parse(this.tbWaveSpeed.Text),
                ZhengLiuEfficient = double.Parse(this.tbZhengLiuEfficent.Text)
            };
            return model;
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            FormUtils.SavePressureData("距离", this.chartMaxPre);
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定要退出吗？", "提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK) ;
            this.Close();
        }
    }
}
