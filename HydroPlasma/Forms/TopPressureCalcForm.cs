using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
                    CalcPressureByProbeLenX(model);
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

        private void CalcPressureByProbeLenX(MaxPressureModel model)
        {
            //throw new NotImplementedException();
            //throw new NotImplementedException();
            int ponitNum = 20;
            //每一条线
            this.chartMaxPre.Series.Clear();
            double maxX = 0;
            for (int i = 0; i < model.LineNum; i++)
            {
                //当前线下的放电能量
                //double currentProbeLength = model.ProbeMinLength + i * (model.ProbeMaxLength - model.ProbeMinLength) / (model.LineNum - 1);

                //最高最低能量
                double minEnergy = 0.5 * model.CapacityVal * model.OutputVoltage * model.OutputVoltage * model.MinCapacityNum;
                double maxEnergy = 0.5 * model.CapacityVal * model.OutputVoltage * model.OutputVoltage * model.MaxCapacityNum;
                //当前线下的能量
                double currentEnergy = minEnergy + i * (maxEnergy - minEnergy) / (model.LineNum - 1);
                //x坐标
                double[] proLenArr = new double[ponitNum];
                for (int j = 0; j < proLenArr.Length; j++)
                {
                    proLenArr[j] = model.ProbeMinLength + j * (model.ProbeMaxLength - model.ProbeMinLength) / (ponitNum - 1);
                }
                //计算最大电极
                maxX = proLenArr[ponitNum - 1] > maxX ? proLenArr[ponitNum - 1] : maxX;
                double[] maxPressureArr = new double[ponitNum];
                //计算y坐标
                for (int k = 0; k < proLenArr.Length; k++)
                {
                    maxPressureArr[k] = model.ComplexFuncBeita * 100 * Math.Sqrt(currentEnergy * 0.24 / (proLenArr[k] / 10)) / 4;
                }
                //画图
                Series ss = new Series("放电能量" + (int)currentEnergy + "J");
                ss.Points.DataBindXY(proLenArr, maxPressureArr);
                ss.BorderWidth = 3;
                ss.ChartType = SeriesChartType.Spline;
                this.chartMaxPre.Series.Add(ss);
            }
            //修改X坐标轴
            int maxX2 = ((int)maxX / 10 + 1) * 10;
            this.chartMaxPre.ChartAreas[0].AxisX.Minimum = 0;
            this.chartMaxPre.ChartAreas[0].AxisX.Maximum = maxX2;
            //修改坐标轴标题
            this.chartMaxPre.ChartAreas[0].AxisX.Title = "电极间距 mm";
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
                double currentProbeLength = model.ProbeMinLength + i * (model.ProbeMaxLength - model.ProbeMinLength) / (model.LineNum - 1);
                //最高最低能量
                double minEnergy = 0.5 * model.CapacityVal * model.OutputVoltage * model.OutputVoltage * model.MinCapacityNum;
                double maxEnergy = 0.5 * model.CapacityVal * model.OutputVoltage * model.OutputVoltage * model.MaxCapacityNum;
                //x坐标
                double[] energyArr = new double[ponitNum];
                for (int j = 0; j < energyArr.Length; j++)
                {
                    energyArr[j] = minEnergy + j * (maxEnergy - minEnergy) / (energyArr.Length - 1);
                }
                //计算最大能量值
                maxX = energyArr[19] > maxX ? energyArr[19] : maxX;
                double[] maxPressureArr = new double[energyArr.Length];
                //计算y坐标
                for (int k = 0; k < energyArr.Length; k++)
                {
                    maxPressureArr[k] = model.ComplexFuncBeita * 100 * Math.Sqrt(energyArr[k] * 0.24 / (currentProbeLength / 10)) / 4;
                }
                //画图
                Series ss = new Series("电极距离" + (int)currentProbeLength + "mm");
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
            //坐标轴刻度类型
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

        private void btnSaveImg_Click(object sender, EventArgs e)
        {
            //保存文件的对话框
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

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            string xType = this.comboBox1.SelectedItem.ToString();
            switch (xType)
            {
                case "电容器储存能量"://电容储能横坐标
                    FormUtils.SavePressureData("能量",this.chartMaxPre);
                    break;
                case "电极间距":
                    FormUtils.SavePressureData("间距", this.chartMaxPre);
                    break;
            }
        }

        //private void SaveData(string xName)
        //{
        //    //throw new NotImplementedException();
        //    //获取当前图像上的数据
        //    var data = GetChartData(this.chartMaxPre);
        //    //打开对话框
        //    SaveFileDialog fileDialog = new SaveFileDialog();
        //    fileDialog.Filter = "All files (*.*)|*.*|文本文件 (*.txt)|*.txt";
        //    fileDialog.FilterIndex = 2;
        //    fileDialog.InitialDirectory = Application.StartupPath;
        //    string fileName = Guid.NewGuid().ToString();
        //    fileDialog.FileName = fileName;
        //    if (fileDialog.ShowDialog() == DialogResult.OK && fileDialog.FileName != "")
        //    {
        //        fileName = fileDialog.FileName;
        //    }
        //    //写入数据
        //    using (StreamWriter sw = new StreamWriter(fileName, false))
        //    {
        //        //标题
        //        foreach (var item in data)
        //        {
        //            sw.Write("\t"+item.Key + "\t");
        //        }
        //        sw.WriteLine();
        //        //写坐标轴
        //        foreach (var item in data)
        //        {
        //            sw.Write("\t" + xName + "  "+"压力"+"\t");
        //        }
        //        sw.WriteLine();
        //        //获得数组的长度
        //        var len = data.FirstOrDefault().Value.GetLength(0);
        //        //开始写入数组
        //        for (int i = 0; i < len; i++)
        //        {
        //            foreach (var point in data)
        //            {
        //                sw.Write("\t" + point.Value[i, 0].ToString("0.00") + "  " + point.Value[i, 1].ToString("0.00") + "\t");
        //            }
        //            sw.WriteLine();
        //        }
        //    }
        //    MessageBox.Show("写入成功！！");
        //}

        //获取当前图像上的所有坐标点
        //private Dictionary<String, double[,]> GetChartData(Chart chart)
        //{
        //    var series = chart.Series;
        //    Dictionary<String, double[,]> dic = new Dictionary<string, double[,]>();
        //    foreach (var line in series)
        //    {
        //        var points = line.Points;
        //        var name = line.Name;
        //        var arr = new double[points.Count, 2];
        //        for (int i = 0; i < points.Count; i++)
        //        {
        //            arr[i, 0] = points[i].XValue;
        //            arr[i, 1] = points[i].YValues[0];
        //        }
        //        dic.Add(name, arr);
        //    }
        //    return dic;
        //}
    }
}
