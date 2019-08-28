using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Database
{
    public class RecemNascido
    {
        private String dataRegistro;
        private String numeroDVNDO;
        private String nomeRN;
        private String sexRN;
        private String dataNascimentoRN;
        private String horaNascimentoRN;
        private int idsexRN;

        public RecemNascido()
        {

        }

        public RecemNascido(string dataRegistro, string numeroDVNDO, string nomeRN, string sexRN, string dataNascimentoRN, string horaNascimentoRN)
        { 
            this.DataRegistro = dataRegistro;
            this.NumeroDVNDO = numeroDVNDO;
            this.NomeRN = nomeRN;
            this.SexRN = sexRN;
            this.DataNascimentoRN = dataNascimentoRN;
            this.HoraNascimentoRN = horaNascimentoRN;
            this.IdsexRN = sexId(sexRN);
        }

        public bool validaDnvDo(String nDnvDO, String Livro)
        {
            String tempnDnvDO = nDnvDO;
            int qtd = Regex.Matches(nDnvDO, "-").Count;
            if (qtd >= 1)
            {
                tempnDnvDO = tempnDnvDO.Remove(nDnvDO.Length - 1);
                tempnDnvDO = tempnDnvDO.Replace("-", "");
            }
            Double CalcDnvDO = Convert.ToInt64(tempnDnvDO);
            if (Livro == "A" && CalcDnvDO > 0043700001 && CalcDnvDO < 0048101001)
            {
                if (calcDV1(CalcDnvDO, nDnvDO))
                {
                    return true;
                }
                return false;
            }
            else if (Livro == "A" && CalcDnvDO >= 3048101000)
            {
                if (calcDV2A(CalcDnvDO, nDnvDO))
                {
                    return true;
                }
                return false;
            }
            else if (Livro == "A" && CalcDnvDO < 43700001 && nDnvDO.Length >= 8)
            {
                return true;
            }
            else if (Livro == "C AUX" && CalcDnvDO < 12075501 && nDnvDO.Length >= 8)
            {
                return true;
            }
            else if (Livro == "C AUX" && CalcDnvDO >= 12075501 && CalcDnvDO < 13600000)
            {
                if (calcDV1(CalcDnvDO, nDnvDO))
                {
                    return true;
                }
                return false;
            }
            else if (Livro == "C AUX" && CalcDnvDO > 13600000)
            {
                if (calcDV2C(CalcDnvDO, nDnvDO))
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        private Boolean calcDV1(double calcDnvDO, String valida)
        {
            Double DigitoVerificador = calcDnvDO % 11;
            if (DigitoVerificador == 10)
            {
                DigitoVerificador = 0;
            }
            valida = valida.Substring(valida.Length - 1, 1);
            if (DigitoVerificador == Convert.ToInt32(valida))
            {
                return true;
            }
            return false;
        }

        private Boolean calcDV2A(double calcDnvDO, String valida)
        {
            String scalcDV2 = Convert.ToString(calcDnvDO);
            double multiplicados = 0;

            char[] array = scalcDV2.ToCharArray();
            int[] inteiros = new int[array.Length];
            int[] pesos = { 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            for (int i = 0; i < array.Length; i++)
            {
                char caracter = array[i];
                inteiros[i] = Convert.ToInt32(caracter) - 48;
            }
            for (int i = 0; i < inteiros.Length; i++)
            {
                multiplicados += inteiros[i] * pesos[i];
            }
            double resultado = (multiplicados % 11) - 11;
            resultado = Math.Abs(resultado);
            valida = valida.Substring(valida.Length - 1, 1);
            if (resultado == Convert.ToInt64(valida))
            {
                return true;
            }
            return false;
        }

        private Boolean calcDV2C(double calcDnvDO, String valida)
        {
            String scalcDV2 = Convert.ToString(calcDnvDO);
            double multiplicados = 0;

            char[] array = scalcDV2.ToCharArray();
            int[] inteiros = new int[array.Length];
            int[] pesos = { 9, 8, 7, 6, 5, 4, 3, 2 };
            if (array.Length >= 10)
            {
                return false;
            }
            for (int i = 0; i < array.Length; i++)
            {
                char caracter = array[i];
                inteiros[i] = Convert.ToInt32(caracter) - 48;
            }
            for (int i = 0; i < inteiros.Length; i++)
            {
                multiplicados += inteiros[i] * pesos[i];
            }
            double resultado = (multiplicados % 11) - 11;
            resultado = Math.Abs(resultado);
            valida = valida.Substring(valida.Length - 1, 1);
            if (resultado == Convert.ToInt64(valida))
            {
                return true;
            }
            return false;
        }

        public int sexId(String sexRN)
        {
            int sex;
            if(sexRN == "Masculino")
            {
                sex = 1;
            }
            else
            {
                sex = 2;
            }
            return sex;
        }

        public string DataRegistro { get => dataRegistro; set => dataRegistro = value; }
        public string NumeroDVNDO { get => numeroDVNDO; set => numeroDVNDO = value; }
        public string NomeRN { get => nomeRN; set => nomeRN = value; }
        public string SexRN { get => sexRN; set => sexRN = value; }
        public string DataNascimentoRN { get => dataNascimentoRN; set => dataNascimentoRN = value; }
        public string HoraNascimentoRN { get => horaNascimentoRN; set => horaNascimentoRN = value; }
        public int IdsexRN { get => idsexRN; set => idsexRN = value; }
    }
}
