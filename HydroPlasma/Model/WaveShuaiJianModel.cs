using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydroPlasma.Model
{
    public class WaveShuaiJianModel
    {
        public double Density { get; set; }
        public double PulseUptime { get; set; }
        public double PulseWidth { get; set; }
        public double ComplexFuncBeita { get; set; }
        public double CapacityEnergy { get; set; }
        public double BianYaEfficient { get; set; }
        public double ZhengLiuEfficient { get; set; }
        public double ShuDianEfficient { get; set; }
        public double ProbeMinLength { get; set; }
        public double ProbeMaxLength { get; set; }
        public int LineNum { get; set; }
        public double ShuaJianConst { get; set; }
        public double MinLen { get; set; }
        public double MaxLen { get; set; }
        public double WaveSpeed { get; set; }
        public double Ele2WaveEfficient { get; set; }

    }
}
