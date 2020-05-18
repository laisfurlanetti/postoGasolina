using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postoGasolina
{
    class Program
    {
        static void Main(string[] args)
        {
            string combustivel;
            double resultado, litros, desconto = 0;


            Console.Write("(A-Alcool ou G-Gasolina) \n Qual tipo de combustivel o senhor deseja: ");
            combustivel = Console.ReadLine().ToLower();
            Console.Write("Quantos litros: ");
            litros = Convert.ToDouble(Console.ReadLine());

            if (combustivel == "a" && litros <= 20)
            {
                resultado = 2.90 * litros;
                desconto = resultado - (3 * resultado) / 100;
            }
            if(combustivel == "a" && litros > 20)
            {
                resultado = 2.90 * litros;
                desconto = resultado - (5 * resultado) / 100;
            }
            if (combustivel == "g" && litros <= 20)
            {
                resultado = 4.50 * litros;
                desconto = resultado - (4 * resultado) / 100;
            }
            if (combustivel == "g" && litros > 20)
            {
                resultado = 4.50 * litros;
                desconto = resultado - (6 * resultado) / 100;
            }

            Console.Write("voce pagara R$" + desconto);
            Console.Read();
        }
    }
}
