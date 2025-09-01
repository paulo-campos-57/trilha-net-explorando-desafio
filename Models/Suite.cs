namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {
        public Suite() { }

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }

        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }

        public void InfoSuite()
        {
            Console.WriteLine("\n");
            Console.WriteLine("==================Informação da suíte:==================");
            Console.WriteLine($"Tipo da suíte: {TipoSuite}");
            Console.WriteLine($"Capacidade da suíte: {Capacidade}");
            Console.WriteLine($"Valor da diária da suíte: {ValorDiaria}");
            Console.WriteLine("========================================================");
            Console.WriteLine("\n");
        }
    }
}