using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database;

namespace Desafio_DeMaria
{
    public partial class ViewCadastro : Form 
    {
        RecemNascido rn;
        Parentesco parente;
        Conexao conexao;
        Livro_Registro livro;

        public ViewCadastro()
        {            
            InitializeComponent();

            //Inicializa a conexao com o banco
            conexao = new Conexao();
            lblDate.Text = DateTime.Now.Date.ToShortDateString(); //Insere a data atual na label
            //Preenche as a cboNaturalidade com as cidades já cadastradas no banco de dados (evitar repetições)
            DataTable dt = conexao.preencheCidades();
            cboNaturalidadeMae.DisplayMember = "cidade";
            cboNaturalidadeMae.DataSource = dt;
            cboNaturalidadePai.DisplayMember = "cidade";
            cboNaturalidadePai.DataSource = dt;
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Botão Salvar -> métodos de cadastro
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                RecemNascido rn = new RecemNascido();
                if (VerificaCamposPreenchidos())
                { 
                    if (rn.validaDnvDo(txtNumeroDNVDO.Text, Convert.ToString(cboLivroRegistro.SelectedItem)))
                    {
                        conexao = new Conexao();
                        //Cadastro do Recem Nascido
                        rn = getDadosRN();
                        conexao.cadastrarRN(rn);
                        livro = getDadosLivro();
                        conexao.cadastrarLivroRegistro(livro);

                        //Cadastro de parentesco do RN
                        parente = getDadosParente("Mae"); //Cadastra MAE
                        conexao.cadastrarParente(parente);
                        parente = getDadosParente("Pai"); //Cadastra PAI
                        conexao.cadastrarParente(parente);

                        MessageBox.Show("Cadastrado com Sucesso!");
                        ClearForm(this); //Limpa form após cadastrar com sucesso
                    }
                    else
                    {
                        MessageBox.Show("Insira um Dnv / DO Valido!");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha os campos obrigatórios!");
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Erro! " + ex);
            }
            
        }

        //Método para limpar o form
        public static void ClearForm(System.Windows.Forms.Control parent)
        {
            foreach (System.Windows.Forms.Control ctrControl in parent.Controls)
            {
                //Loop through all controls 
                if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.TextBox)))
                {
                    //Check to see if it's a textbox 
                    ((System.Windows.Forms.TextBox)ctrControl).Text = string.Empty;
                    //If it is then set the text to String.Empty (empty textbox) 
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.RichTextBox)))
                {
                    //If its a RichTextBox clear the text
                    ((System.Windows.Forms.RichTextBox)ctrControl).Text = string.Empty;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.MaskedTextBox)))
                {
                    //If its a RichTextBox clear the text
                    ((System.Windows.Forms.MaskedTextBox)ctrControl).Text = string.Empty;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.ComboBox)))
                {
                    //Next check if it's a dropdown list 
                    ((System.Windows.Forms.ComboBox)ctrControl).SelectedIndex = -1;
                    //If it is then set its SelectedIndex to 0 
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.CheckBox)))
                {
                    //Next uncheck all checkboxes
                    ((System.Windows.Forms.CheckBox)ctrControl).Checked = false;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.RadioButton)))
                {
                    //Unselect all RadioButtons
                    ((System.Windows.Forms.RadioButton)ctrControl).Checked = false;
                }
                if (ctrControl.Controls.Count > 0)
                {
                    //Call itself to get all other controls in other containers 
                    ClearForm(ctrControl);
                }
            }
        }

        //Verifica o preenchimento dos campos
        private bool VerificaCamposPreenchidos()
        {
            if (txtNumeroDNVDO.Text.Equals("") || txtNomeRN.Text.Equals("") || txtNomePai.Text.Equals("") || txtNomeMae.Text.Equals(""))
            {
                return false;
            }
            return true;
        }

        //Insere os dados do form no objeto RecemNascido
        private RecemNascido getDadosRN()
        {
            rn = new RecemNascido(
            mskTxtDataRegistro.Text,
            txtNumeroDNVDO.Text,
            txtNomeRN.Text,
            Convert.ToString(cboSexo.SelectedItem),
            mskTxtDataNascimento.Text,
            mskTxtHoraNascimento.Text);
            return rn;
        }

        //Insere dados no obj Livro_Registro
        private Livro_Registro getDadosLivro()
        {
            livro = new Livro_Registro(
            cboLivroRegistro.Text,
            Convert.ToInt32(txtNumLivro.Text),
            Convert.ToInt32(txtNumPagina.Text),
            Convert.ToInt32(txtNumRegistro.Text));
            return livro;
        }
        
        //Insere dados no obj Parentesco
        public Parentesco getDadosParente(String tipo)
        {          
           
            if(tipo == "Mae"){
                parente = new Parentesco(
                txtNomeMae.Text,
                mskTxtNascimentoMae.Text,
                cboNaturalidadeMae.Text,
                cboUfMae.Text,
                tipo,
                chkPrazo.Checked,
                mskTxtDataRegistro.Text);
                return parente;
            }
            else
            {
                parente = new Parentesco(
                txtNomePai.Text,
                mskTxtNascimentoPai.Text,
                cboNaturalidadePai.Text,
                cboUfPai.Text,
                tipo,
                chkPrazo.Checked,
                mskTxtDataRegistro.Text);
                return parente;
            }
            
        }

        //Método de Consulta
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            dtGridConsulta.DataSource = null;

            if (cboParametroPesquisa.Text != "" && txtPesquisa.Text != "") //Confere se o campo de pesquisa e tipo de pesquisa estão preenchidos
            {
                conexao = new Conexao();
                if (cboParametroPesquisa.Text == "Nome RN")
                {
                    dtGridConsulta.DataSource = conexao.consultaNomeRN(txtPesquisa.Text);
                }
                else if (cboParametroPesquisa.Text == "Parentesco")
                {
                    dtGridConsulta.DataSource = conexao.consultaParentesco(txtPesquisa.Text);
                }
                else if (cboParametroPesquisa.Text == "Dnv / Do")
                {
                    dtGridConsulta.DataSource = conexao.consultaDnvDo(txtPesquisa.Text);
                }
            }
            else
            {
                if (cboParametroPesquisa.Text == "")
                {
                    MessageBox.Show("Selecione um parâmetro de pesquisa!");
                }
                else if (txtPesquisa.Text == "")
                {
                    MessageBox.Show("Digite algo no campo pesquisa!");
                }
            }
        }

        //Impedir que o usuario digite em ComboBox
        private void cboLivroRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cboSexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cboUfPai_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cboUfMae_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}   
