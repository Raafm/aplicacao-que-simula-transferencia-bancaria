using System;

namespace DIO
{
    public class Conta{
         
        private bool pessoa_fisica{get;set;}
        private double saldo{get;set;}
        private double credito{get;set;}
        private string nome {get;set;}

        
        public Conta(bool Pessoa_fisica, double Saldo,double Credito,string Nome){
            
            this.pessoa_fisica = Pessoa_fisica;
            this.saldo = Saldo;
            this.credito = Credito;
            this.nome = Nome;
        }
        public bool Sacar(double Valor){
            Console.WriteLine("Saldo atual: {0}", this.saldo);
            if(Valor <= 0){
                Console.WriteLine("Valor sacado deve ser positivo");
                return false;
            }
            
            if(this.saldo + this.credito> Valor){
                
                this.saldo -= Valor;
                Console.WriteLine("Saldo atual de {0}, é: ",this.nome,this.saldo);
                return true;
            }
            else{
                Console.WriteLine("Saldo insuficiente");
                return false;
            }
        }
        public bool Depositar(double Valor){
            if(Valor < 0.01) return false;
            else{
                this.saldo += Valor;
                return true;
            } 
        }

        public bool Transferir(double Valor, Conta outra){
            if(Valor < 0.01){
                Console.WriteLine("Valor transferido deve ser positivo");
                return false;
            }
            else if(this.saldo >= Valor){
                outra.saldo += Valor;
                this.saldo -= Valor;
                return true;
            }
            else{
                Console.WriteLine("saldo insuficiente");
                return false;
            }
        }
        public void print_conta(int i){
            Console.Write("{0}: {1}\n saldo: {2},   credito: {3}",i,this.nome,this.saldo,this.credito);
            if(this.pessoa_fisica)Console.WriteLine("\npessoafisica\n");
            else Console.WriteLine("\npessoa juridica\n");
        }
    }

}
