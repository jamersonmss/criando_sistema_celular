namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; private set; }
        public string Imei { get; private set; }
        public int Memoria { get; private set; } 

        // Foi implementado acima o que faltava, abaixo de número.
        
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;

            // Implementado construtor acima
        }

        protected Smartphone(string nome)
        {
        }

        // Métodos
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        // Método abstrato
        public abstract void InstalarAplicativo(string nomeApp);
    }
}