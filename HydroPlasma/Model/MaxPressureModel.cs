using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydroPlasma
{
   public class MaxPressureModel
    {
        public double Density { get; set; }
        public double PulseUptime { get; set; }
        public double PulseWidth { get; set; }
        public double ComplexFuncBeita { get; set; }
        public double CapacityVal { get; set; }
        public int MaxCapacityNum { get; set; }
        public int MinCapacityNum { get; set; }
        public double OutputVoltage { get; set; }
        public double ProbeMinLength { get; set; }
        public double ProbeMaxLength { get; set; }
        public int LineNum { get; set; }
    }
}
