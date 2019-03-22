using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Entidades
{
    public class Contatos
    {
        public string telefones { get; set; }

        public override string ToString()
        {
            return this.telefones;
        }
    }
}
