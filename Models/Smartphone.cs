
namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Imei { get; set; }
        private string Modelo { get; set; }
        private string Memoria { get; set; }

        public Smartphone(string numero, string modelo, string memoria, string imei)
        {
            Numero = numero;
            Imei = imei;
            Modelo = modelo;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);

        internal void InstalarAplicativo()
        {
            throw new NotImplementedException();
        }
    }
}