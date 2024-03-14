using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinca
{
    internal class Odontologia:Clinica
    {
        private string tipo;
        private double valorOdonto;

        public string Tipo { get => tipo; set => tipo = value; }
        public double ValorOdonto { get => valorOdonto; set => valorOdonto = value; }


        override public string MostraDados()
        {
            return base.MostraDados() + "\n" + "Tipo de Tratamento: " + Tipo + "\n" + "Valor da Consulta: " + "R$ " + Valor();
        }
        override public double Valor()
        {
            if (Condicao==0)
                return ValorOdonto - (ValorOdonto * 0.2); //20% de desconto
            return ValorOdonto;
        }
    }
}
