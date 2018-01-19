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
    public partial class TopPressureCalcForm : Form
    {
        public TopPressureCalcForm()
        {
            InitializeComponent();
           this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalcMaxPre_Click(object sender, EventArgs e)
        {
            //初始化数据
            var model = InitailData();
            //判断横坐标的类型
            string xType = this.comboBox1.SelectedItem.ToString();
            switch (xType)
            {
                case "电容器储存能量"://电容储能横坐标
                    CalcPressureByEnergyX(model);
                    break;
                case "电极间距":
                    break;
            }
            //double  minEnergy = 100 ;
            //double maxEnergy = 2000;
            //double probeLen = 10;
            //double[] energy = new double[20];
            //double[] maxPre = new double[energy.Length];
            //for (int i = 0; i < 20; i++)
            //{
            //    energy[i] = minEnergy + i*(maxEnergy - minEnergy) / 19;
            //}
            ////计算峰值压力
            //for (int i = 0; i < energy.Length; i++)
            //{
            //    maxPre[i] = 70 * Math.Sqrt(energy[i]*0.24) / 4;
            //}
            ////画图
            //chartMaxPre.Series[0].Points.DataBindXY(energy, maxPre);
        }

        /// <summary>
        ///将电容器能量作为X坐标
        /// </summary>
        /// <param name="model"></param>
        private void CalcPressureByEnergyX(MaxPressureModel model)
        {
            //throw new NotImplementedException();
            int ponitNum = 20;
            //每一条线
            this.chartMaxPre.Series.Clear();
            double maxX = 0;


            for (int i = 0; i < model.LineNum; i++)
            {
                //当前线下的电极距离
                double currentProbeLength = model.ProbeMinLength + i*(model.ProbeMaxLength - model.ProbeMinLength) / (model.LineNum - 1);
                //最高最低能量
                double minEnergy = 0.5 * model.CapacityVal * model.OutputVoltage * model.OutputVoltage*model.MinCapacityNum;
                double maxEnergy = 0.5*model.CapacityVal * model.OutputVoltage * model.OutputVoltage * model.MaxCapacityNum;
                //x坐标
                double[] energyArr = new double[ponitNum];
                for (int j= 0; j < energyArr.Length; j++)
                {
                    energyArr[j] = minEnergy + j * (maxEnergy - minEnergy) / (energyArr.Length - 1);
                }
                //计算最大能量值
                maxX= energyArr[19] > maxX ? energyArr[19] :maxX;
                double[] maxPressureArr= new double[energyArr.Length];
                //计算y坐标
                for (int k = 0; k < energyArr.Length; k++)
                {
                    maxPressureArr[k] = model.ComplexFuncBeita *100* Math.Sqrt(energyArr[k] * 0.24 / (currentProbeLength / 10)) / 4;
                }
                //画图
                Series ss = new Series( "电极距离"+currentProbeLength+"mm");
                ss.Points.DataBindXY(energyArr, maxPressureArr);
                ss.BorderWidth = 3;
                ss.ChartType = SeriesChartType.Spline;
                this.chartMaxPre.Series.Add(ss);
            }
            //修改X坐标轴
            int maxX2 = ((int)maxX / 100 + 1) * 100;
            this.chartMaxPre.ChartAreas[0].AxisX.Minimum = 0;
            this.chartMaxPre.ChartAreas[0].AxisX.Maximum = maxX2;
            //修改坐标轴标题
            this.chartMaxPre.ChartAreas[0].AxisX.Title = "电容器储存能量 J";
            this.chartMaxPre.ChartAreas[0].AxisY.Title = "峰值压力 MPa";
            //不显示网格线
            this.chartMaxPre.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            this.chartMaxPre.ChartAreas[0].AxisX.ArrowStyle = AxisArrowStyle.Triangle;
            this.chartMaxPre.ChartAreas[0].AxisY.ArrowStyle = AxisArrowStyle.Triangle;
            // this.chartMaxPre.ChartAreas[0].AxisX.IsMarginVisible = false;
            TickMark t = new TickMark();
            t.TickMarkStyle = TickMarkStyle.None;
            this.chartMaxPre.ChartAreas[0].AxisX.MajorTickMark = t;
            this.chartMaxPre.ChartAreas[0].AxisY.MajorTickMark = t;


            //this.chartMaxPre.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
        }

        private MaxPressureModel InitailData()
        {
            MaxPressureModel model = new MaxPressureModel();
            model.Density = Double.Parse(tbDensity.Text);
            model.PulseUptime = Double.Parse(tbPulseUpTime.Text);
            model.PulseWidth = Double.Parse(tbPulseWidth.Text);
            model.ComplexFuncBeita = Double.Parse(tbComplexFuncBeita.Text);
            model.CapacityVal = Double.Parse(tbCapacityVal.Text);
            model.MinCapacityNum = Int32.Parse(tbCapacityMinNum.Text);
            model.MaxCapacityNum = Int32.Parse(tbCapacityMaxNum.Text);
            model.OutputVoltage = Double.Parse(tbOutputVoltage.Text);
            model.ProbeMinLength = Double.Parse(tbMinProbeLength.Text);
            model.ProbeMaxLength = Double.Parse(tbMaxProbeLength.Text);
            model.LineNum = Int32.Parse(tbLineNum.Text);
            return model;
        }

        private void TopPressureCalcForm_Load(object sender, EventArgs e)
        {
            this.comboBox1.SelectedIndex = 0;
            // MessageBox.Show(this.comboBox1.);
        }
    }
}
