using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HydroPlasma
{
    public static class FormUtils
    {
        //保存数据
        public static void SavePressureData(string xName,Chart chart)
        {
            //throw new NotImplementedException();
            //获取当前图像上的数据
            var data = FormUtils.GetChartData(chart);
            //打开对话框
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "All files (*.*)|*.*|文本文件 (*.txt)|*.txt";
            fileDialog.FilterIndex = 2;
            fileDialog.InitialDirectory = Application.StartupPath;
            string fileName = Guid.NewGuid().ToString();
            fileDialog.FileName = fileName;
            if (fileDialog.ShowDialog() == DialogResult.OK && fileDialog.FileName != "")
            {
                fileName = fileDialog.FileName;
            }
            //写入数据
            using (StreamWriter sw = new StreamWriter(fileName, false))
            {
                //标题
                foreach (var item in data)
                {
                    sw.Write("\t" + item.Key + "\t");
                }
                sw.WriteLine();
                //写坐标轴
                foreach (var item in data)
                {
                    sw.Write("\t" + xName + "  " + "压力" + "\t");
                }
                sw.WriteLine();
                //获得数组的长度
                var len = data.FirstOrDefault().Value.GetLength(0);
                //开始写入数组
                for (int i = 0; i < len; i++)
                {
                    foreach (var point in data)
                    {
                        sw.Write("\t" + point.Value[i, 0].ToString("0.00") + "  " + point.Value[i, 1].ToString("0.00") + "\t");
                    }
                    sw.WriteLine();
                }
            }
            MessageBox.Show("写入成功！！");
        }
        //从图像上获取数据
        public static Dictionary<String, double[,]> GetChartData(Chart chart)
        {
            var series = chart.Series;
            Dictionary<String, double[,]> dic = new Dictionary<string, double[,]>();
            foreach (var line in series)
            {
                var points = line.Points;
                var name = line.Name;
                var arr = new double[points.Count, 2];
                for (int i = 0; i < points.Count; i++)
                {
                    arr[i, 0] = points[i].XValue;
                    arr[i, 1] = points[i].YValues[0];
                }
                dic.Add(name, arr);
            }
            return dic;
        }
    }
}
