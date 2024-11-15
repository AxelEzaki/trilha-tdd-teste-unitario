using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trilha_tdd_calculadora_api.Entidade
{
    public class Calculadora
    {
        private List<string> historico { get; set;}
        public string data;

        public Calculadora(string data)
        {
            historico = new List<string>();
            this.data = data;
        }

        public int Somar(int num1, int num2)
        {
            var res = num1 + num2;

            historico.Insert(0, nameof(Somar) + " Res: " + res + " - data: " + data);

            return res;
        }
        public int Subtrair(int num1, int num2)
        {
            var res = num1 - num2;

            historico.Insert(0, nameof(Subtrair) + " Res: " + res + " - data: " + data);

            return res;
        }
        public int Multiplicar(int num1, int num2)
        {
            var res = num1 * num2;

            historico.Insert(0, nameof(Multiplicar) + " Res: " + res + " - data: " + data);
            
            return res;
        }
        public int Dividir(int num1, int num2)
        {
            var res = num1 / num2;

            historico.Insert(0, nameof(Dividir) + " Res: " + res + " - data: " + data);
            
            return res;
        }
        public List<string> Historico()
        {
            historico.RemoveRange(3, historico.Count - 3);

            return historico;
        }
    }
}