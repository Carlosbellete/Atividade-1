using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontnetFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do 1° aluno");
            string nomedoaluno1 = (Console.ReadLine());
            Console.Write("Digite a 1° nota de" + nomedoaluno1 + ": ");
            double nota11 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a 2° nota de" + nomedoaluno1 + ": ");
            double nota12 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a 3° nota de" + nomedoaluno1 + ": ");
            double nota13 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a 4° nota de" + nomedoaluno1 + ": ");
            double nota14 = Convert.ToDouble(Console.ReadLine());
            double soma = nota11 + nota12 + nota13 + nota14;
            double mediaaluno1 = soma / 4;
            Console.WriteLine("A media do aluno é = "+ mediaaluno1);
            Console.Write("Digite o nome do 2° aluno");
            string nomedoaluno2 = (Console.ReadLine());
            Console.Write("Digite a 1° nota de" + nomedoaluno2 + ": ");
            double nota21 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a 2° nota de" + nomedoaluno2 + ": ");
            double nota22 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a 3° nota de" + nomedoaluno2 + ": ");
            double nota23 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a 4° nota de" + nomedoaluno2 + ": ");
            double nota24 = Convert.ToDouble(Console.ReadLine());
            double soma2 = nota21 + nota22 + nota23 + nota24;
            double mediaaluno2 = soma2 / 4;
            Console.WriteLine("A media do aluno é = " + mediaaluno2);
            Console.Write("Digite o nome do 3° aluno");
            string nomedoaluno3 = (Console.ReadLine());
            Console.Write("Digite a 1° nota de" + nomedoaluno3 + ": ");
            double nota31 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a 2° nota de" + nomedoaluno3 + ": ");
            double nota32 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a 3° nota de" + nomedoaluno3 + ": ");
            double nota33 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a 4° nota de" + nomedoaluno3 + ": ");
            double nota34 = Convert.ToDouble(Console.ReadLine());
            double soma3 = nota31 + nota32 + nota33 + nota34;
            double mediaaluno3 = soma3 / 4;
            Console.WriteLine("A media do aluno é = " + mediaaluno3);
            Console.Write("Digite o nome do 4° aluno");
            string nomedoaluno4 = (Console.ReadLine());
            Console.Write("Digite a 1° nota de" + nomedoaluno4 + ": ");
            double nota41 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a 2° nota de" + nomedoaluno4 + ": ");
            double nota42 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a 3° nota de" + nomedoaluno4 + ": ");
            double nota43 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a 4° nota de" + nomedoaluno4 + ": ");
            double nota44 = Convert.ToDouble(Console.ReadLine());
            double soma4 = nota41 + nota42 + nota43 + nota44;
            double mediaaluno4 = soma / 4;
            Console.WriteLine("A media do aluno é = " + mediaaluno4);
            double x = (mediaaluno1);
            double y = (mediaaluno2);
            double k = (mediaaluno3);
            double z = (mediaaluno4);
            Console.WriteLine("O aluno 1 está na média?");
            Console.WriteLine(x > 7 ? "sim" : "não");
            Console.WriteLine("O aluno 2 está na média?");
            Console.WriteLine(y > 7 ? "sim" : "não");
            Console.WriteLine("O aluno 3 está na média?");
            Console.WriteLine(k > 7 ? "sim" : "não");
            Console.WriteLine("O aluno 4 está na média?");
            Console.WriteLine(z > 7 ? "sim" : "não");
            Console.ReadKey();
        }
    }
}
