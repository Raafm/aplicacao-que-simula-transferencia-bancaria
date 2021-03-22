using System; 
using System.Collections.Generic;

namespace DIO
{
    class minhaClasse {

        static List<Conta> lista_contas = new List<Conta>();

        static void Main(string[] args) { 
            char escolha = '1';
            while(escolha != '0'){
                escolha = char.Parse(opcao_usuario());
                switch(escolha){
                    case '0': 
                        break;
                    case '1': 
                        Sacar();
                        break;
                    case '2': 
                        Depositar();
                        break;
                    case '3': 
                        Transferir();
                        break;
                    case '4': 
                        Inserir_conta();
                        break;
                    case '5': 
                        listar_contas();
                        break;
            
                    default:
                        throw new ArgumentException();
                }
            }
        }         
        static string opcao_usuario(){
            Console.WriteLine("Para sair,          digite: 0");
            Console.WriteLine("Para sacar,         digite: 1");
            Console.WriteLine("Para depositar,     digite: 2");
            Console.WriteLine("Para transferir,    digite: 3");
            Console.WriteLine("Para inserir conta, digite: 4");
            Console.WriteLine("Para listar contas, digite: 5");

            string r = Console.ReadLine();
            return r;
        }

        static void Inserir_conta(){
            
            Console.WriteLine("Escreva o nome do usuario: ");
            string Xnome = Console.ReadLine();

            Console.WriteLine("digite      false      para pessoa juridica, e    true    para fisica: ");
            bool Xpessoa_fisica = bool.Parse(Console.ReadLine());

            Console.WriteLine("Saldo inicial: ");
            double Xsaldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Credito inicial: ");
            double Xcredito = double.Parse(Console.ReadLine());


            Conta new_conta = new Conta(Nome: Xnome,Pessoa_fisica: Xpessoa_fisica, Saldo: Xsaldo, Credito: Xcredito);

            lista_contas.Add(new_conta);
        }

        static void listar_contas(){
            if( lista_contas.Count == 0 ){
                Console.WriteLine("Nenhuma conta cadastrada: ");
            }
            else{
                for(int i  =0; i < lista_contas.Count; i++){
                    lista_contas[i].print_conta(i);
                    
                    
                }
                    
            }
        }
        static void Sacar(){
            Console.WriteLine("digite numero da conta: ");
            
            int Numero_conta = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o Valor: ");
            double Valor = double.Parse(Console.ReadLine()); 

            lista_contas[Numero_conta].Sacar(Valor);
        }

        static void Depositar(){
            Console.WriteLine("digite numero da conta: ");
            
            int Numero_conta = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o Valor: ");
            double Valor = double.Parse(Console.ReadLine()); 

            lista_contas[Numero_conta].Depositar(Valor);
            
        }
        static void Transferir(){
            Console.WriteLine("digite numero da conta que enviara: ");            
            int Numero_conta_DE = int.Parse(Console.ReadLine());

            Console.WriteLine("digite numero da conta que recebera: ");
            int Numero_conta_PARA = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o Valor: ");
            double Valor = double.Parse(Console.ReadLine()); 

            lista_contas[Numero_conta_DE].Transferir(Valor,lista_contas[Numero_conta_PARA]);
        }
    }   
}
