char continuar = 's';

string nome, cnpj;
int segmento;
decimal faturamento;
decimal faturamentoTotal = 0;
decimal impostoEmpresa = 0;
decimal impostoTotal = 0;
decimal impostoAgro = 0;
decimal impostoIndustria = 0;
decimal impostoServico = 0;

while(continuar == 's')
{
    Console.WriteLine("Informe o nome da empresa: ");
    nome = Console.ReadLine();
    
    Console.WriteLine("Informe o CNPJ da empresa: ");
    cnpj = Console.ReadLine();

    Console.WriteLine("Digite agora o faturamento da empresa: ");
    faturamento = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("Digite o segmento da empresa: ");
    Console.WriteLine("[1] Agro");
    Console.WriteLine("[2] Indústria");
    Console.WriteLine("[3] Serviços");
    segmento = Convert.ToInt32(Console.ReadLine());

    faturamentoTotal += faturamento;

    switch (segmento)
    {
        case 1:
            impostoEmpresa = faturamento * 0.02m;
            impostoAgro += impostoEmpresa;
            break;
        case 2:
            impostoEmpresa = faturamento * 0.05m;
            impostoIndustria += impostoEmpresa;
            break;
        case 3:
            impostoEmpresa = faturamento * 0.08m;
            impostoServico += impostoEmpresa;
            break;
    }

    Console.WriteLine("Imposto gerado pela empresa: " + impostoEmpresa);

    impostoTotal += impostoEmpresa;

    Console.WriteLine("Deseja Continuar? (s/n)");
    continuar = Console.ReadLine()[0];
}

    Console.WriteLine("O faturamento total é de: " + faturamentoTotal);
    Console.WriteLine("O imposto total é de: " + impostoTotal);
    Console.WriteLine("Imposto do Agronegócio: " + impostoAgro);
    Console.WriteLine("Imposto das indústrias: " + impostoIndustria);
    Console.WriteLine("Imposto das empresas de serviços: " + impostoServico);