using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public class Parentesco
    {
        private String nome;
        private String data_nascimento;
        private String naturalidade;
        private String uf;
        private int idade;
        private int id_parentesco;
        private Boolean prazoRegistro;

        public Parentesco()
        {

        }

        public Parentesco(string nome, String data_nascimento, string naturalidade, string uf, String tipo_parente, bool prazoRegistro, String dt_registroRN)
        {
            this.nome = nome;
            this.data_nascimento = data_nascimento;
            this.naturalidade = naturalidade;
            this.uf = uf;
            if(tipo_parente == "Mãe")
            {
                this.idade = calculaIdadeMae(prazoRegistro, dt_registroRN);
                this.Id_parentesco = idParentesco(tipo_parente);
            }
            else
            {
                this.idade = calculaIdadePai(dt_registroRN);
                this.Id_parentesco = idParentesco(tipo_parente);
            }
            
        }

        //Métodos para calculo de idade dos parentes
        private int calculaIdadePai(string dt_registroRN)
        {
            int idadePai;
            String registro_rn = Convert.ToString(dt_registroRN).Remove(0, 6);
            String dt_nascimentoPai = Convert.ToString(Data_nascimento).Remove(0, 6);
            idadePai = Convert.ToInt32(registro_rn) - Convert.ToInt32(dt_nascimentoPai);
            return idadePai;
        }
        //Calculo idade mae
        private int calculaIdadeMae(bool prazoRegistro, string dt_registroRN)
        {
            int idadeMae;
            String dt_nascimentoMae = Convert.ToString(Data_nascimento).Remove(0, 6);
            if (prazoRegistro)
            {
                idadeMae = DateTime.Now.Year - Convert.ToInt32(dt_nascimentoMae);
            }
            else
            {
                String registro_rn = Convert.ToString(dt_registroRN).Remove(0, 6);
                idadeMae = Convert.ToInt32(registro_rn) - Convert.ToInt32(dt_nascimentoMae);
            }
            return idadeMae;
        }
        //Retorna o id dos parentes para cadastro no banco de dados
        public int idParentesco(String tipo_parente)
        {
            if(tipo_parente == "Pai")
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        //Getters e Setters
        public string Nome { get => nome; set => nome = value; }
        public string Data_nascimento { get => data_nascimento; set => data_nascimento = value; }
        public string Naturalidade { get => naturalidade; set => naturalidade = value; }
        public string Uf { get => uf; set => uf = value; }
        public int Idade { get => idade; set => idade = value; }
        public bool PrazoRegistro { get => prazoRegistro; set => prazoRegistro = value; }
        public int Id_parentesco { get => id_parentesco; set => id_parentesco = value; }
    }
}
