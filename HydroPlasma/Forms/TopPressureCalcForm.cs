using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HydroPlasma.Forms
{
    public partial class TopPressureCalcForm : Form
    {
        public TopPressureCalcForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalcMaxPre_Click(object sender, EventArgs e)
        {
            double  minEnergy = 100 ;
            double maxEnergy = 2000;
            double probeLen = 10;
            double[] energy = new double[20];
            double[] maxPre = new double[energy.Length];
            for (int i = 0; i < 20; i++)
            {
                energy[i] = minEnergy + i*(maxEnergy - minEnergy) / 19;
            }
            //计算峰值压力
            for (int i = 0; i < energy.Length; i++)
            {
                maxPre[i] = 70 * Math.Sqrt(energy[i]*0.24) / 4;
            }
            //画图
            chartMaxPre.Series[0].Points.DataBindXY(energy, maxPre);
        }
    }
}
