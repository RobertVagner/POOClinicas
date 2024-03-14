using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pessoa;

namespace Clinca
{
    abstract internal class Clinica
    {
        protected PessoaCad obj_Pessoa;
        private int condicao;

        public PessoaCad Obj_Pessoa { get => obj_Pessoa; set => obj_Pessoa = value; }
        public int Condicao { get => condicao; set => condicao = value; }

        public Clinica()
        {
            Obj_Pessoa = new PessoaCad();
        }
        virtual public string MostraDados()
        {
            return "Nome: " + Obj_Pessoa.Nome + "\n" + "Telefone: " + Obj_Pessoa.Telefone + "\n" + Obj_Pessoa.Obj_cpf.MostraCPF() + "\n" + "Status: " + Valcpf() + "\n" + "Data de Nascimento: " + Obj_Pessoa.Obj_data.BigData();
        }
        public string Valcpf()
        {
            string auxcpf = Obj_Pessoa.Obj_cpf.Cpf;
            if (Obj_Pessoa.Obj_cpf.ValidaCpf(auxcpf) == false)
                return "Cpf inválido";
            else
                return "Cpf válido";
        }
        abstract public double Valor();
    }
}
