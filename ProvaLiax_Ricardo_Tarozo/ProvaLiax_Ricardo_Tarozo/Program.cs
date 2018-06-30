using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaLiax_Ricardo_Tarozo
{
    class Program
    {
        static void Main(string[] args)
        {
            Conectar conectar = new Conectar();

            while (true)
            {
                Console.WriteLine("Selecione uma Opção, digite Sair para finalizar");
                Console.WriteLine("1 = Incluir Aluno");
                Console.WriteLine("2 = Alterar Aluno");
                Console.WriteLine("3 = Excluir Aluno");
                Console.WriteLine("4 = Incluir Disciplina");
                Console.WriteLine("5 = Vincular Aluno a Disciplina");

                string line = Console.ReadLine(); //Pega a opção digitada
                if (line == "Sair")
                {
                    break;
                }
                if (line == "1")
                { }
                if (line == "2")
                { }
                if (line == "3")
                { }
                if (line == "4")
                { }
                if (line == "5")
                { }
                if (line == "6")
                { }
                if (line == "7")
                { }
                if (line == "8")
                { }
                if (line == "9")
                { }

                Console.Write("Sua opção");
                
            }
        }
    }
}
