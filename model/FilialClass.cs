using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMainWindow.model
{
   public class FilialClass
    {
        public FilialClass(string firmName, string firmAddres, int countWorkers)
        {
            this.FirmName = firmName;
            this.CountSotr = countWorkers;
            this.FirmAddres = firmAddres;
           
        }
        public string FirmName { get; set; }
        public string FirmAddres { get; set; }

        public int CountSotr { get; set; }

        //public List<Sotrudnick> Sotrudnics { get; set; }

        //public voi
    }
}
