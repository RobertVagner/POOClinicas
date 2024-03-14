namespace Clinca
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOdontologia = new System.Windows.Forms.Button();
            this.btnExameVista = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAddOdonto = new System.Windows.Forms.Button();
            this.btnAddExameVista = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtCondição = new System.Windows.Forms.TextBox();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtInfo1 = new System.Windows.Forms.TextBox();
            this.txtInfo2 = new System.Windows.Forms.TextBox();
            this.txtTipoTratamento = new System.Windows.Forms.TextBox();
            this.txtValorConsulta = new System.Windows.Forms.TextBox();
            this.btnPesquisaNome = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPesquisaNome = new System.Windows.Forms.TextBox();
            this.lblResultadoPesquisa = new System.Windows.Forms.Label();
            this.lblResultadoTipo = new System.Windows.Forms.Label();
            this.txtPesquisaTipo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOdontologia
            // 
            this.btnOdontologia.Location = new System.Drawing.Point(46, 55);
            this.btnOdontologia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOdontologia.Name = "btnOdontologia";
            this.btnOdontologia.Size = new System.Drawing.Size(278, 36);
            this.btnOdontologia.TabIndex = 0;
            this.btnOdontologia.Text = "Odontologia";
            this.btnOdontologia.UseVisualStyleBackColor = true;
            this.btnOdontologia.Click += new System.EventHandler(this.btnOdontologia_Click);
            // 
            // btnExameVista
            // 
            this.btnExameVista.Location = new System.Drawing.Point(365, 55);
            this.btnExameVista.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExameVista.Name = "btnExameVista";
            this.btnExameVista.Size = new System.Drawing.Size(278, 36);
            this.btnExameVista.TabIndex = 1;
            this.btnExameVista.Text = "Exame de Vista";
            this.btnExameVista.UseVisualStyleBackColor = true;
            this.btnExameVista.Click += new System.EventHandler(this.btnExameVista_Click);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(42, 123);
            this.lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(63, 18);
            this.lb.TabIndex = 3;
            this.lb.Text = "Nome: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telefone: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "CPF: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 226);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(443, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Você veio por encaminhamento? Digite (0) SIM / (1) NÃO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 267);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Data de Nacimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 310);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 310);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mês:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(449, 310);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ano:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 369);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(226, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "Já fez exame de vista antes?";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 406);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(257, 18);
            this.label9.TabIndex = 12;
            this.label9.Text = "Pretende usar lentes de contato?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 478);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 18);
            this.label10.TabIndex = 13;
            this.label10.Text = "Valor da Consulta: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 439);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 18);
            this.label12.TabIndex = 15;
            this.label12.Text = "Tipo da Tratamento:";
            // 
            // btnAddOdonto
            // 
            this.btnAddOdonto.Location = new System.Drawing.Point(45, 519);
            this.btnAddOdonto.Name = "btnAddOdonto";
            this.btnAddOdonto.Size = new System.Drawing.Size(598, 39);
            this.btnAddOdonto.TabIndex = 17;
            this.btnAddOdonto.Text = "Adicionar Paciente de Odontologia";
            this.btnAddOdonto.UseVisualStyleBackColor = true;
            this.btnAddOdonto.Click += new System.EventHandler(this.btnAddOdonto_Click);
            // 
            // btnAddExameVista
            // 
            this.btnAddExameVista.Location = new System.Drawing.Point(45, 564);
            this.btnAddExameVista.Name = "btnAddExameVista";
            this.btnAddExameVista.Size = new System.Drawing.Size(598, 39);
            this.btnAddExameVista.TabIndex = 18;
            this.btnAddExameVista.Text = "Adicionar Paciente de Exame de Vista";
            this.btnAddExameVista.UseVisualStyleBackColor = true;
            this.btnAddExameVista.Click += new System.EventHandler(this.btnAddExameVista_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(112, 117);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(531, 24);
            this.txtNome.TabIndex = 19;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(128, 151);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(515, 24);
            this.txtTelefone.TabIndex = 20;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(112, 185);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(531, 24);
            this.txtCpf.TabIndex = 21;
            // 
            // txtCondição
            // 
            this.txtCondição.Location = new System.Drawing.Point(501, 223);
            this.txtCondição.Name = "txtCondição";
            this.txtCondição.Size = new System.Drawing.Size(142, 24);
            this.txtCondição.TabIndex = 22;
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(82, 304);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(138, 24);
            this.txtDia.TabIndex = 23;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(290, 304);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(130, 24);
            this.txtMes.TabIndex = 24;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(501, 304);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(142, 24);
            this.txtAno.TabIndex = 25;
            // 
            // txtInfo1
            // 
            this.txtInfo1.Location = new System.Drawing.Point(275, 363);
            this.txtInfo1.Name = "txtInfo1";
            this.txtInfo1.Size = new System.Drawing.Size(368, 24);
            this.txtInfo1.TabIndex = 26;
            // 
            // txtInfo2
            // 
            this.txtInfo2.Location = new System.Drawing.Point(306, 400);
            this.txtInfo2.Name = "txtInfo2";
            this.txtInfo2.Size = new System.Drawing.Size(337, 24);
            this.txtInfo2.TabIndex = 27;
            // 
            // txtTipoTratamento
            // 
            this.txtTipoTratamento.Location = new System.Drawing.Point(209, 436);
            this.txtTipoTratamento.Name = "txtTipoTratamento";
            this.txtTipoTratamento.Size = new System.Drawing.Size(434, 24);
            this.txtTipoTratamento.TabIndex = 29;
            // 
            // txtValorConsulta
            // 
            this.txtValorConsulta.Location = new System.Drawing.Point(196, 472);
            this.txtValorConsulta.Name = "txtValorConsulta";
            this.txtValorConsulta.Size = new System.Drawing.Size(447, 24);
            this.txtValorConsulta.TabIndex = 31;
            // 
            // btnPesquisaNome
            // 
            this.btnPesquisaNome.Location = new System.Drawing.Point(819, 55);
            this.btnPesquisaNome.Name = "btnPesquisaNome";
            this.btnPesquisaNome.Size = new System.Drawing.Size(306, 36);
            this.btnPesquisaNome.TabIndex = 32;
            this.btnPesquisaNome.Text = "Pesquisa por Nome";
            this.btnPesquisaNome.UseVisualStyleBackColor = true;
            this.btnPesquisaNome.Click += new System.EventHandler(this.btnPesquisaNome_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(816, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 18);
            this.label14.TabIndex = 33;
            this.label14.Text = "Digite o Nome: ";
            // 
            // txtPesquisaNome
            // 
            this.txtPesquisaNome.Location = new System.Drawing.Point(936, 111);
            this.txtPesquisaNome.Name = "txtPesquisaNome";
            this.txtPesquisaNome.Size = new System.Drawing.Size(189, 24);
            this.txtPesquisaNome.TabIndex = 34;
            // 
            // lblResultadoPesquisa
            // 
            this.lblResultadoPesquisa.AutoSize = true;
            this.lblResultadoPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoPesquisa.Location = new System.Drawing.Point(816, 154);
            this.lblResultadoPesquisa.Name = "lblResultadoPesquisa";
            this.lblResultadoPesquisa.Size = new System.Drawing.Size(160, 18);
            this.lblResultadoPesquisa.TabIndex = 35;
            this.lblResultadoPesquisa.Text = "Resultado da Pesquisa";
            // 
            // lblResultadoTipo
            // 
            this.lblResultadoTipo.AutoSize = true;
            this.lblResultadoTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoTipo.Location = new System.Drawing.Point(816, 493);
            this.lblResultadoTipo.Name = "lblResultadoTipo";
            this.lblResultadoTipo.Size = new System.Drawing.Size(160, 18);
            this.lblResultadoTipo.TabIndex = 39;
            this.lblResultadoTipo.Text = "Resultado da Pesquisa";
            // 
            // txtPesquisaTipo
            // 
            this.txtPesquisaTipo.Location = new System.Drawing.Point(936, 450);
            this.txtPesquisaTipo.Name = "txtPesquisaTipo";
            this.txtPesquisaTipo.Size = new System.Drawing.Size(189, 24);
            this.txtPesquisaTipo.TabIndex = 38;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(816, 456);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 18);
            this.label13.TabIndex = 37;
            this.label13.Text = "Digite o CPF: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(819, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(306, 36);
            this.button1.TabIndex = 36;
            this.button1.Text = "Pesquisa por CPF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 632);
            this.Controls.Add(this.lblResultadoTipo);
            this.Controls.Add(this.txtPesquisaTipo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblResultadoPesquisa);
            this.Controls.Add(this.txtPesquisaNome);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnPesquisaNome);
            this.Controls.Add(this.txtValorConsulta);
            this.Controls.Add(this.txtTipoTratamento);
            this.Controls.Add(this.txtInfo2);
            this.Controls.Add(this.txtInfo1);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.txtCondição);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnAddExameVista);
            this.Controls.Add(this.btnAddOdonto);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.btnExameVista);
            this.Controls.Add(this.btnOdontologia);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdontologia;
        private System.Windows.Forms.Button btnExameVista;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAddOdonto;
        private System.Windows.Forms.Button btnAddExameVista;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtCondição;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtInfo1;
        private System.Windows.Forms.TextBox txtInfo2;
        private System.Windows.Forms.TextBox txtTipoTratamento;
        private System.Windows.Forms.TextBox txtValorConsulta;
        private System.Windows.Forms.Button btnPesquisaNome;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPesquisaNome;
        private System.Windows.Forms.Label lblResultadoPesquisa;
        private System.Windows.Forms.Label lblResultadoTipo;
        private System.Windows.Forms.TextBox txtPesquisaTipo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
    }
}

