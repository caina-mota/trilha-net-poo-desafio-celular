namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        protected string Modelo { get; set; }
        protected string IMEI { get; set; }
        protected int Memoria { get; set; }
        protected List<string> AplicativosInstalados { get; set; } = new();

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
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
        public void ListarAplicativosInstalados()
        {
            System.Console.WriteLine("Aplicativos Instalados:");
            foreach(var app in AplicativosInstalados)
                System.Console.WriteLine(app);
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}