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
            conexao = new Conexao();
            lblDate.Text = DateTime.Now.Date.ToShortDateString();
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                RecemNascido rn = new RecemNascido();
                if (VerificaCamposPreenchidos())
                { //ARRUMAR A PORRA DOS COMBO BOX AAAAAAAAAA
                    if (rn.validaDnvDo(txtNumeroDNVDO.Text, Convert.ToString(cboLivroRegistro.SelectedItem)))
                    {
                        conexao = new Conexao();
                        rn = getDadosRN();
                        conexao.cadastrarRN(rn);
                        livro = getDadosLivro();
                        conexao.cadastrarLivroRegistro(livro);

                        parente = getDadosParente("Mae");
                        conexao.cadastrarParente(parente);

                        parente = getDadosParente("Pai");
                        conexao.cadastrarParente(parente);
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

        private bool VerificaCamposPreenchidos()
        {
            if (txtNumeroDNVDO.Text.Equals("") || txtNomeRN.Text.Equals(""))
            {
                return false;
            }
            return true;
        }

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

        private Livro_Registro getDadosLivro()
        {
            livro = new Livro_Registro(
            cboLivroRegistro.SelectedText,
            Convert.ToInt32(txtNumLivro.Text),
            Convert.ToInt32(txtNumPagina.Text),
            Convert.ToInt32(txtNumRegistro.Text));
            return livro;
        }
        
        public Parentesco getDadosParente(String tipo)
        {          
           
            if(tipo == "Mae"){
                parente = new Parentesco(
                txtNomeMae.Text,
                mskTxtNascimentoMae.Text,
                cboNaturalidadeMae.Text,
                cboUfMae.Text,
                tipo,
                chkPrazo.Checked);
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
                chkPrazo.Checked);
                return parente;
            }
            
        }

        private void btnTelaCadastro_Click(object sender, EventArgs e)
        {

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            dtGridConsulta.DataSource = null;

            if (cboParametroPesquisa.Text != "" && txtPesquisa.Text != "")
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
