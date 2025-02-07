using System.Reflection.PortableExecutable;

namespace estacionamento.Models{

    public class Estacionamento{

        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {

            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;

        }

        public void AdicionarVeiculo(){

            Console.WriteLine("Digite a placa do véiculo a adicionar");
            string placa = Console.ReadLine().ToUpper();
            
            if (veiculos.Contains(placa)){
                Console.WriteLine("Veiculo já está na base, digite outra placa");
                
            }
            else{
                veiculos.Add(placa);
                Console.WriteLine("O veículo foi adicionado com sucesso");
            }
           
            }
            

        public void ExcluirVeiculo(){

            Console.WriteLine("Digite a placa do véiculo que deseja excluir:");
            string placa = Console.ReadLine().ToUpper();
            
            if (veiculos.Contains(placa)){
                Console.WriteLine("Quantas horas horas o véiculo permaneceu estacionado?");
                if(decimal.TryParse(Console.ReadLine(), out decimal horasPermanecidas) && horasPermanecidas >= 0){
                    decimal valorTotal = precoInicial + (precoPorHora*horasPermanecidas);
                    veiculos.Remove(placa);
                    Console.WriteLine($"Veiculo {placa} excluído, total a pagar R$ {valorTotal:F2}");

                }

                else{
                    Console.WriteLine("Horas inválidas, digite uma hora válida.");

                }
                    
            }
            else{
                Console.WriteLine("Veículo não pode ser excluído, pois não foi adicionado.");
            }
        }

        public void ListarVeiculos(){
            
                if (!veiculos.Any()){
                    Console.WriteLine("Não há veículos na lista");
                }

                else{

                    Console.WriteLine("Os veiculos estacionados são:");

                    foreach (string veiculo in veiculos){
                        Console.WriteLine($"{veiculo}");
                    }
                
                    

                }

                
            
            
        }
}

}

