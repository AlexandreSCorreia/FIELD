using ImgPosInst.Models;
using System.Collections.Generic;

namespace ImgPosInst.Helper
{
    public class Config
    {
        public List<string> machineTypeList { get; set; }
        public List<string> o365Config { get; set; }
        public List<string> wXEPowerPlan { get; set; }
        public List<string> wXEServices { get; set; }
        public List<string> winstore { get; set; }
        public List<string> wXEPerformance { get; set; }
        public List<string> controleAtivos { get; set; }
        public List<Unidade> unidades { get; set; }
        public List<string> appsWindows { get; set; }
        public string remoteCon { get; set; }
        public string siglaPlais { get; set; }
        //TODO: COnfigurações default 
        public string dominio { get; set; }
    }
}
