using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Desafio
{
    public class Estacionamento
    {
        private int precoInicial = 0;
        private int precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(int precoInicial, int precoPorHora) {
            this.precoInicial = precoInicial;//This refere-se a variavel de instancia
            this.precoPorHora = precoPorHora;
        }
        
        
        public void AdicionarVeiculo() {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            veiculos.Add(Console.ReadLine());
            
        }
        public void RemoverVeiculo() {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();
            

            //Pra verificar se o veiculo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper())) {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = int.Parse(Console.ReadLine());
                int valorTotal = precoInicial + precoPorHora * horas;

                veiculos.Remove(placa);

                Console.WriteLine("O veículo " + placa + " foi removido e o preço total foi de: " + valorTotal);
            }
            else {
                Console.WriteLine("Desculpa mas esse veículo não foi estacionado aqui. Confira se digitou a placa corretamente");
            }

        }
        public void ListarVeiculo() {
            //Verificar se há veículo no estacionamento

            if (veiculos.Any()) {
                Console.WriteLine("Os veículos estacionados são:");
                for (int contador = 0; contador < veiculos.Count; contador++) {
                    Console.WriteLine(veiculos[contador]);
                }

                
            }
            else {
                Console.WriteLine("Não há veículos estacionados");
            }
        }


    }
}