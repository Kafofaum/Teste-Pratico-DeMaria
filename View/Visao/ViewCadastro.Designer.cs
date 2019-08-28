namespace Desafio_DeMaria
{
    partial class ViewCadastro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboLivroRegistro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumLivro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumPagina = new System.Windows.Forms.TextBox();
            this.txtNumRegistro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomeRN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNomePai = new System.Windows.Forms.TextBox();
            this.txtNomeMae = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cboNaturalidadeMae = new System.Windows.Forms.ComboBox();
            this.cboNaturalidadePai = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.chkPrazo = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNumeroDNVDO = new System.Windows.Forms.TextBox();
            this.mskTxtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.mskTxtNascimentoPai = new System.Windows.Forms.MaskedTextBox();
            this.mskTxtNascimentoMae = new System.Windows.Forms.MaskedTextBox();
            this.mskTxtHoraNascimento = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboUfPai = new System.Windows.Forms.ComboBox();
            this.cboUfMae = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.mskTxtDataRegistro = new System.Windows.Forms.MaskedTextBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.cboParametroPesquisa = new System.Windows.Forms.ComboBox();
            this.dtGridConsulta = new System.Windows.Forms.DataGridView();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(103)))), ((int)(((byte)(141)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 54);
            this.panel1.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(103)))), ((int)(((byte)(141)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Image = global::View.Properties.Resources.btnSair;
            this.btnExit.Location = new System.Drawing.Point(800, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(38, 31);
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDate.Location = new System.Drawing.Point(557, 19);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(168, 17);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "Data em tempo real aqui";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(499, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Data:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Livro de Registro";
            // 
            // cboLivroRegistro
            // 
            this.cboLivroRegistro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLivroRegistro.FormattingEnabled = true;
            this.cboLivroRegistro.Items.AddRange(new object[] {
            "A",
            "C AUX"});
            this.cboLivroRegistro.Location = new System.Drawing.Point(134, 70);
            this.cboLivroRegistro.Name = "cboLivroRegistro";
            this.cboLivroRegistro.Size = new System.Drawing.Size(73, 23);
            this.cboLivroRegistro.TabIndex = 1;
            this.cboLivroRegistro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboLivroRegistro_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Livro N°";
            // 
            // txtNumLivro
            // 
            this.txtNumLivro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumLivro.Location = new System.Drawing.Point(279, 70);
            this.txtNumLivro.Name = "txtNumLivro";
            this.txtNumLivro.Size = new System.Drawing.Size(52, 21);
            this.txtNumLivro.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(345, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Página";
            // 
            // txtNumPagina
            // 
            this.txtNumPagina.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumPagina.Location = new System.Drawing.Point(404, 70);
            this.txtNumPagina.Name = "txtNumPagina";
            this.txtNumPagina.Size = new System.Drawing.Size(48, 21);
            this.txtNumPagina.TabIndex = 3;
            // 
            // txtNumRegistro
            // 
            this.txtNumRegistro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumRegistro.Location = new System.Drawing.Point(532, 70);
            this.txtNumRegistro.Name = "txtNumRegistro";
            this.txtNumRegistro.Size = new System.Drawing.Size(100, 21);
            this.txtNumRegistro.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(458, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Registro N°";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nome";
            // 
            // txtNomeRN
            // 
            this.txtNomeRN.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeRN.Location = new System.Drawing.Point(134, 113);
            this.txtNomeRN.Name = "txtNomeRN";
            this.txtNomeRN.Size = new System.Drawing.Size(498, 21);
            this.txtNomeRN.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(660, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Sexo";
            // 
            // cboSexo
            // 
            this.cboSexo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cboSexo.Location = new System.Drawing.Point(713, 113);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(110, 23);
            this.cboSexo.TabIndex = 7;
            this.cboSexo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboSexo_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Nascimento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(229, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Hora do Nascimento";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(29, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "Nome do Pai";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(31, 286);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 15);
            this.label12.TabIndex = 24;
            this.label12.Text = "Nome da Mãe";
            // 
            // txtNomePai
            // 
            this.txtNomePai.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomePai.Location = new System.Drawing.Point(134, 200);
            this.txtNomePai.Name = "txtNomePai";
            this.txtNomePai.Size = new System.Drawing.Size(498, 21);
            this.txtNomePai.TabIndex = 11;
            // 
            // txtNomeMae
            // 
            this.txtNomeMae.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeMae.Location = new System.Drawing.Point(134, 283);
            this.txtNomeMae.Name = "txtNomeMae";
            this.txtNomeMae.Size = new System.Drawing.Size(498, 21);
            this.txtNomeMae.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(31, 245);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 15);
            this.label13.TabIndex = 27;
            this.label13.Text = "Nascimento ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(253, 329);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 15);
            this.label14.TabIndex = 29;
            this.label14.Text = "Naturalidade";
            // 
            // cboNaturalidadeMae
            // 
            this.cboNaturalidadeMae.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNaturalidadeMae.FormattingEnabled = true;
            this.cboNaturalidadeMae.Location = new System.Drawing.Point(362, 326);
            this.cboNaturalidadeMae.Name = "cboNaturalidadeMae";
            this.cboNaturalidadeMae.Size = new System.Drawing.Size(100, 23);
            this.cboNaturalidadeMae.TabIndex = 17;
            // 
            // cboNaturalidadePai
            // 
            this.cboNaturalidadePai.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNaturalidadePai.FormattingEnabled = true;
            this.cboNaturalidadePai.Location = new System.Drawing.Point(362, 241);
            this.cboNaturalidadePai.Name = "cboNaturalidadePai";
            this.cboNaturalidadePai.Size = new System.Drawing.Size(100, 23);
            this.cboNaturalidadePai.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(253, 245);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 15);
            this.label15.TabIndex = 32;
            this.label15.Text = "Naturalidade";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(31, 329);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 15);
            this.label16.TabIndex = 33;
            this.label16.Text = "Nascimento ";
            // 
            // chkPrazo
            // 
            this.chkPrazo.AutoSize = true;
            this.chkPrazo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPrazo.Location = new System.Drawing.Point(663, 288);
            this.chkPrazo.Name = "chkPrazo";
            this.chkPrazo.Size = new System.Drawing.Size(148, 19);
            this.chkPrazo.TabIndex = 19;
            this.chkPrazo.Text = "Cadastrado no prazo?";
            this.chkPrazo.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.LightGray;
            this.btnSalvar.Image = global::View.Properties.Resources.btnCadastro;
            this.btnSalvar.Location = new System.Drawing.Point(713, 316);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(43, 39);
            this.btnSalvar.TabIndex = 20;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(648, 73);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 15);
            this.label17.TabIndex = 41;
            this.label17.Text = "DNV / DO";
            // 
            // txtNumeroDNVDO
            // 
            this.txtNumeroDNVDO.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroDNVDO.Location = new System.Drawing.Point(713, 70);
            this.txtNumeroDNVDO.Name = "txtNumeroDNVDO";
            this.txtNumeroDNVDO.Size = new System.Drawing.Size(110, 21);
            this.txtNumeroDNVDO.TabIndex = 5;
            // 
            // mskTxtDataNascimento
            // 
            this.mskTxtDataNascimento.Location = new System.Drawing.Point(134, 156);
            this.mskTxtDataNascimento.Mask = "00/00/0000";
            this.mskTxtDataNascimento.Name = "mskTxtDataNascimento";
            this.mskTxtDataNascimento.Size = new System.Drawing.Size(89, 20);
            this.mskTxtDataNascimento.TabIndex = 8;
            this.mskTxtDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // mskTxtNascimentoPai
            // 
            this.mskTxtNascimentoPai.Location = new System.Drawing.Point(134, 242);
            this.mskTxtNascimentoPai.Mask = "00/00/0000";
            this.mskTxtNascimentoPai.Name = "mskTxtNascimentoPai";
            this.mskTxtNascimentoPai.Size = new System.Drawing.Size(89, 20);
            this.mskTxtNascimentoPai.TabIndex = 12;
            this.mskTxtNascimentoPai.ValidatingType = typeof(System.DateTime);
            // 
            // mskTxtNascimentoMae
            // 
            this.mskTxtNascimentoMae.Location = new System.Drawing.Point(134, 327);
            this.mskTxtNascimentoMae.Mask = "00/00/0000";
            this.mskTxtNascimentoMae.Name = "mskTxtNascimentoMae";
            this.mskTxtNascimentoMae.Size = new System.Drawing.Size(89, 20);
            this.mskTxtNascimentoMae.TabIndex = 16;
            this.mskTxtNascimentoMae.ValidatingType = typeof(System.DateTime);
            // 
            // mskTxtHoraNascimento
            // 
            this.mskTxtHoraNascimento.Location = new System.Drawing.Point(366, 156);
            this.mskTxtHoraNascimento.Mask = "00:00";
            this.mskTxtHoraNascimento.Name = "mskTxtHoraNascimento";
            this.mskTxtHoraNascimento.Size = new System.Drawing.Size(40, 20);
            this.mskTxtHoraNascimento.TabIndex = 9;
            this.mskTxtHoraNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(490, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "UF";
            // 
            // cboUfPai
            // 
            this.cboUfPai.FormattingEnabled = true;
            this.cboUfPai.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TP"});
            this.cboUfPai.Location = new System.Drawing.Point(532, 242);
            this.cboUfPai.Name = "cboUfPai";
            this.cboUfPai.Size = new System.Drawing.Size(100, 21);
            this.cboUfPai.TabIndex = 14;
            this.cboUfPai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboUfPai_KeyPress);
            // 
            // cboUfMae
            // 
            this.cboUfMae.FormattingEnabled = true;
            this.cboUfMae.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TP"});
            this.cboUfMae.Location = new System.Drawing.Point(532, 327);
            this.cboUfMae.Name = "cboUfMae";
            this.cboUfMae.Size = new System.Drawing.Size(100, 21);
            this.cboUfMae.TabIndex = 18;
            this.cboUfMae.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboUfMae_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(490, 329);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(21, 13);
            this.label18.TabIndex = 49;
            this.label18.Text = "UF";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(433, 159);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 13);
            this.label19.TabIndex = 50;
            this.label19.Text = "Data de Registro";
            // 
            // mskTxtDataRegistro
            // 
            this.mskTxtDataRegistro.Location = new System.Drawing.Point(532, 156);
            this.mskTxtDataRegistro.Mask = "00/00/0000";
            this.mskTxtDataRegistro.Name = "mskTxtDataRegistro";
            this.mskTxtDataRegistro.Size = new System.Drawing.Size(100, 20);
            this.mskTxtDataRegistro.TabIndex = 10;
            this.mskTxtDataRegistro.ValidatingType = typeof(System.DateTime);
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConsulta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(103)))), ((int)(((byte)(141)))));
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConsulta.Image = global::View.Properties.Resources.btnPesquisar;
            this.btnConsulta.Location = new System.Drawing.Point(760, 375);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(51, 46);
            this.btnConsulta.TabIndex = 23;
            this.btnConsulta.TabStop = false;
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(12, 394);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(84, 16);
            this.label20.TabIndex = 55;
            this.label20.Text = "Pesquisa por";
            // 
            // cboParametroPesquisa
            // 
            this.cboParametroPesquisa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboParametroPesquisa.FormattingEnabled = true;
            this.cboParametroPesquisa.Items.AddRange(new object[] {
            "Dnv / Do",
            "Nome RN",
            "Parentesco"});
            this.cboParametroPesquisa.Location = new System.Drawing.Point(102, 387);
            this.cboParametroPesquisa.Name = "cboParametroPesquisa";
            this.cboParametroPesquisa.Size = new System.Drawing.Size(135, 24);
            this.cboParametroPesquisa.TabIndex = 21;
            // 
            // dtGridConsulta
            // 
            this.dtGridConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridConsulta.Location = new System.Drawing.Point(12, 427);
            this.dtGridConsulta.Name = "dtGridConsulta";
            this.dtGridConsulta.Size = new System.Drawing.Size(813, 189);
            this.dtGridConsulta.TabIndex = 24;
            this.dtGridConsulta.TabStop = false;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(331, 387);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(403, 22);
            this.txtPesquisa.TabIndex = 22;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(255, 390);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 16);
            this.label21.TabIndex = 51;
            this.label21.Text = "Consulta";
            // 
            // ViewCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(841, 630);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.cboParametroPesquisa);
            this.Controls.Add(this.dtGridConsulta);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.mskTxtDataRegistro);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cboUfMae);
            this.Controls.Add(this.cboUfPai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskTxtHoraNascimento);
            this.Controls.Add(this.mskTxtNascimentoMae);
            this.Controls.Add(this.mskTxtNascimentoPai);
            this.Controls.Add(this.mskTxtDataNascimento);
            this.Controls.Add(this.txtNumeroDNVDO);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.chkPrazo);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cboNaturalidadePai);
            this.Controls.Add(this.cboNaturalidadeMae);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtNomeMae);
            this.Controls.Add(this.txtNomePai);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboSexo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNomeRN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumRegistro);
            this.Controls.Add(this.txtNumPagina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumLivro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboLivroRegistro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewCadastro";
            this.Text = "Cadastro Natimorto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLivroRegistro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumLivro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumPagina;
        private System.Windows.Forms.TextBox txtNumRegistro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNomePai;
        private System.Windows.Forms.TextBox txtNomeMae;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboNaturalidadeMae;
        private System.Windows.Forms.ComboBox cboNaturalidadePai;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox chkPrazo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtNumeroDNVDO;
        private System.Windows.Forms.MaskedTextBox mskTxtDataNascimento;
        private System.Windows.Forms.MaskedTextBox mskTxtNascimentoPai;
        private System.Windows.Forms.MaskedTextBox mskTxtNascimentoMae;
        private System.Windows.Forms.MaskedTextBox mskTxtHoraNascimento;
        public System.Windows.Forms.TextBox txtNomeRN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboUfPai;
        private System.Windows.Forms.ComboBox cboUfMae;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.MaskedTextBox mskTxtDataRegistro;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cboParametroPesquisa;
        private System.Windows.Forms.DataGridView dtGridConsulta;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label21;
    }
}

