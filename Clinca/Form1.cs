using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinca
{
    public partial class Form1 : Form
    {
        List<Clinica> Lista = new List<Clinica>();
        Odontologia o = null;
        ExameDeVista ev = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOdontologia_Click(object sender, EventArgs e)
        {
            o = new Odontologia();
            btnAddExameVista.Enabled = false;
            btnAddOdonto.Enabled = true;
            txtInfo1.Enabled = false;
            txtInfo2.Enabled = false;
            txtTipoTratamento.Enabled = true;
            txtValorConsulta.Enabled = true;
        }

        private void btnExameVista_Click(object sender, EventArgs e)
        {
            ev = new ExameDeVista();
            btnAddExameVista.Enabled = true;
            btnAddOdonto.Enabled = false;
            txtInfo1.Enabled = true;
            txtInfo2.Enabled = true;
            txtTipoTratamento.Enabled = false;
            txtValorConsulta.Enabled = true;
        }

        private void btnAddOdonto_Click(object sender, EventArgs e)
        {
            cadastro(o);
            o.Tipo = txtTipoTratamento.Text;
            o.ValorOdonto = double.Parse(txtValorConsulta.Text);
            Lista.Add(o);
            btnAddOdonto.Enabled = false;
            LimpaTextos();
        }
        private void btnAddExameVista_Click(object sender, EventArgs e)
        {
            cadastro(ev);
            ev.Info1 = txtInfo1.Text;
            ev.Info2 = txtInfo2.Text;
            ev.ValorExame1 = double.Parse(txtValorConsulta.Text);
            Lista.Add(ev);
            btnAddExameVista.Enabled = false;
            LimpaTextos();
        }
        private void cadastro(Clinica p)
        {
            p.Obj_Pessoa.Nome = txtNome.Text;
            p.Obj_Pessoa.Telefone = double.Parse(txtTelefone.Text);
            p.Obj_Pessoa.Obj_cpf.Cpf = txtCpf.Text;
            p.Obj_Pessoa.Obj_data.Dia = int.Parse(txtDia.Text);
            p.Obj_Pessoa.Obj_data.Mes = int.Parse(txtMes.Text);
            p.Obj_Pessoa.Obj_data.Ano = int.Parse(txtAno.Text);
            p.Condicao = int.Parse(txtCondição.Text);
        }

        private void LimpaTextos()
        {
            txtNome.Text = "";
            txtTelefone.Text = "";
            txtCpf.Text = "";
            txtDia.Text = "";
            txtMes.Text = "";
            txtAno.Text = "";
            txtCondição.Text = "";
            txtInfo1.Text = "";
            txtInfo2.Text = "";
            txtTipoTratamento.Text = "";
            txtValorConsulta.Text = "";
        }

        private void btnPesquisaNome_Click(object sender, EventArgs e)
        {
            foreach (var item in Lista)
            {
                if (item.Obj_Pessoa.Nome == txtPesquisaNome.Text)
                    lblResultadoPesquisa.Text = item.MostraDados();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in Lista)
            {
                if (item.Obj_Pessoa.Obj_cpf.Cpf == txtPesquisaTipo.Text)
                    lblResultadoTipo.Text = item.MostraDados();
            }
        }
    }
}
