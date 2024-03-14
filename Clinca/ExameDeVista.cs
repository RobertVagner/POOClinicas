using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinca
{
    internal class ExameDeVista:Clinica
    {
        private string info1;
        private string info2;
        private double ValorExame;

        public string Info1 { get => info1; set => info1 = value; }
        public string Info2 { get => info2; set => info2 = value; }
        public double ValorExame1 { get => ValorExame; set => ValorExame = value; }

        override public string MostraDados()
        {
            return base.MostraDados() + "\n" + "Valor do exame de vista: " + "R$ " + Valor();
        }
        override public double Valor()
        {
            if (Condicao==0)
                return ValorExame1 - (ValorExame1 * 0.5); //50% de desconto
            return ValorExame1;
        }
    }
}
