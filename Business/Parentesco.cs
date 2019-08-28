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
        RecemNascido r;

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

        public Parentesco(string nome, String data_nascimento, string naturalidade, string uf, String tipo_parente, bool prazoRegistro)
        {
            this.nome = nome;
            this.data_nascimento = data_nascimento;
            this.naturalidade = naturalidade;
            this.uf = uf;
            if(tipo_parente == "Mãe")
            {
                this.idade = calculaIdadeMae(prazoRegistro);
                this.Id_parentesco = idParentesco(tipo_parente);
            }
            else
            {
                this.idade = calculaIdadePai();
                this.Id_parentesco = idParentesco(tipo_parente);
            }
            
        }

        private int calculaIdadePai()
        {
            int idadePai;
            String anoNascimento = Convert.ToString(data_nascimento).Remove(0, 6);
            idadePai = DateTime.Now.Year - Convert.ToInt32(anoNascimento);
            return idadePai;
        }

        private int calculaIdadeMae(bool prazoRegistro)
        {
            int idadeMae;
            if (prazoRegistro)
            {
                String anoNascimento = Convert.ToString(data_nascimento).Remove(0, 6);
                idadeMae = DateTime.Now.Year - Convert.ToInt32(anoNascimento);
            }
            else
            {
                String anoNascimento = Convert.ToString(r.DataRegistro);
                idadeMae = Convert.ToInt32(anoNascimento) - DateTime.Now.Year;
            }
            return idadeMae;
        }

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

        public string Nome { get => nome; set => nome = value; }
        public string Data_nascimento { get => data_nascimento; set => data_nascimento = value; }
        public string Naturalidade { get => naturalidade; set => naturalidade = value; }
        public string Uf { get => uf; set => uf = value; }
        public int Idade { get => idade; set => idade = value; }
        public bool PrazoRegistro { get => prazoRegistro; set => prazoRegistro = value; }
        public int Id_parentesco { get => id_parentesco; set => id_parentesco = value; }
    }
}
