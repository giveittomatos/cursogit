using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2 {

    class contaBancaria {
        public int numero {get; private set;}
        public string nome;
        private double saldo;

        public contaBancaria(int numero, string nome){
            this.numero = numero;
            this.nome = nome;
            this.saldo = 0;
        }

        public contaBancaria(int numero, string nome, double saldo){
            this.numero = numero;
            this.nome = nome;
            this.saldo = saldo;
        }

        public void deposito(double quantidade){
            saldo = saldo + quantidade;
        }

        public void levantamento(double quantidade){
            saldo = saldo - quantidade - 5;
        }

        public override string ToString() {
            return "Numero: " + this.numero + ", Titular: " + nome + ", Saldo: " + this.saldo;
        }
    }

    class Program {
        static void Main(string[] args) {

            contaBancaria E;
            string nome;
            int numero;
            double saldo=0;

            Console.Write("Numero: ");
            numero = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Vai por saldo inicial? ");
            if(char.Parse(Console.ReadLine()) == ('s')){
                Console.Write("Saldo: ");
                saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                E = new contaBancaria(numero, nome, saldo);
            }
            else{
                E = new contaBancaria(numero, nome);
            }

            Console.WriteLine();
            Console.WriteLine("Conta Criada");
            Console.WriteLine(E);

            Console.WriteLine();
            Console.Write("Deposito: ");
            E.deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Update");
            Console.WriteLine(E);

            Console.WriteLine();
            Console.Write("Levantamento: ");
            E.levantamento(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Update");
            Console.WriteLine(E);

            Console.ReadLine();

        }
    }
}
