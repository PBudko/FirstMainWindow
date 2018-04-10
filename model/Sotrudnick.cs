using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMainWindow.model
{
  public  class Sotrudnick
    {
        public Sotrudnick(string Email,string filialName)
        {
            this.Email = Email;
            this.FilialName = filialName;
        }
        public string Email { get; set; }
        public string FilialName { get; set; }
        public bool IsSelected { get; set; }
    }
}
