using System;
using System.Globalization;
using System.Collections.Generic;

namespace Course {
    class Program {
        static void Main(string[] args) {
            List<Funcionario> funcionarios = new List<Funcionario>();
            
            Console.Write("Quantos funcionários serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Funcionário {i}: ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcionarios.Add(new Funcionario(id, nome, salario));
            }

            Console.Write("Entre com o id do funcionário quer receberá o aumento: ");
            int pesquisa = int.Parse(Console.ReadLine());
            Funcionario funcionario = funcionarios.Find(obj => obj.Id == pesquisa);
            if (funcionario == null) {
                Console.WriteLine("Esse id não existe!");
            } else {
                Console.Write("Entre com a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                funcionario.aumentarSalario(porcentagem);
            }

            Console.WriteLine("Lista de funcionários atualizada:");
            foreach (Funcionario obj in funcionarios) {
                Console.WriteLine(obj);
            }
        }
    }
}
