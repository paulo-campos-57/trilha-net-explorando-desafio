using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

int option = 1;

do
{
    string tipoSuite;
    int capacidade;
    decimal valorDiaria;

    Console.WriteLine("Informaões sobre a Suíte:");
    Console.Write("Informe o tipo da suíte: ");
    tipoSuite = Console.ReadLine();
    Console.Write("Informe a capacidade da suíte: ");
    capacidade = Convert.ToInt32(Console.ReadLine());
    Console.Write("Informe o valor da diária da suíte: ");
    valorDiaria = Convert.ToDecimal(Console.ReadLine());

    Suite suite = new Suite(tipoSuite: tipoSuite, capacidade: capacidade, valorDiaria: valorDiaria);

    suite.InfoSuite();

    Console.WriteLine("Pressione ENTER para continuar");
    Console.ReadLine();
    Console.Clear();

    int qtdHospedes;
    string nome;
    string sobrenome;
    int diasReservados;
    List<Pessoa> hospedes = new List<Pessoa>();
    Console.Write("Informe a quantidade de hóspedes da suíte: ");
    qtdHospedes = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < qtdHospedes; i++)
    {
        Console.Write($"Informe o nome do {i + 1} hospede: ");
        nome = Console.ReadLine();
        Console.Write($"Informe o sobrenome do {i + 1} hospede: ");
        sobrenome = Console.ReadLine();
        Pessoa p = new Pessoa(nome: nome, sobrenome: sobrenome);
        hospedes.Add(p);
    }

    Console.Write("Informe a quantidade de dias que os hóspedes reservarão a suíte: ");
    diasReservados = Convert.ToInt32(Console.ReadLine());

    Reserva reserva = new Reserva(diasReservados);

    reserva.CadastrarSuite(suite);
    reserva.CadastrarHospedes(hospedes);

    Console.WriteLine("A reserva foi concluída corretamente!");
    Console.WriteLine($"Quantidade de Hóspedes: {reserva.ObterQuantidadeHospedes()}");
    Console.WriteLine("Hóspedes:");
    foreach (var h in hospedes)
    {
        Console.WriteLine($"- {h.Nome} {h.Sobrenome}");
    }

    Console.WriteLine($"Capacidade máxima da suíte: {suite.Capacidade}.");
    Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");

    Console.WriteLine("\nDeseja cadastrar outra suíte?");
    Console.WriteLine("1 = SIM / 0 = NÃO");
    option = Convert.ToInt32(Console.ReadLine());

} while (option != 0);

// // Cria os modelos de hóspedes e cadastra na lista de hóspedes
// List < Pessoa > hospedes = new List<Pessoa>();

// Pessoa p1 = new Pessoa(nome: "Hóspede 1");
// Pessoa p2 = new Pessoa(nome: "Hóspede 2");

// hospedes.Add(p1);
// hospedes.Add(p2);

// // Cria a suíte
// Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// // Cria uma nova reserva, passando a suíte e os hóspedes
// Reserva reserva = new Reserva(diasReservados: 5);
// reserva.CadastrarSuite(suite);
// reserva.CadastrarHospedes(hospedes);

// int sobra = suite.Capacidade - reserva.ObterQuantidadeHospedes();

// // // Exibe a quantidade de hóspedes e o valor da diária
// Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
// Console.WriteLine($"Capacidade máxima da suíte: {suite.Capacidade}, sobrando {sobra} vagas");
// Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");