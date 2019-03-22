using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Entidades
{
    public class Clientes
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }

        public List<Contatos> lstContatos { get; set; }

        //public override string ToString()
        //{
        //    return this.Nome;
        //}
        
    }

}
