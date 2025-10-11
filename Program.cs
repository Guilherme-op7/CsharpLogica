namespace estudos;

class Program
{
    static void Main(string[] args)
    {
        Apresentacao();

        Exercicio01AD03();
    }

    public static void Apresentacao()
    {
        Console.WriteLine("Seja bem vindo a sequencia de exercicios!");
    }

    public static void Exercicio1()
    {
        Console.WriteLine("-- EXERCÍCIO 01 --");

        Console.WriteLine("Informe o valor da compra:");
        double valor = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe o desconto em reais:");
        double desconto = Convert.ToDouble(Console.ReadLine());

        double resultado = Soma(valor, desconto);

        Console.WriteLine($"Valor final da compra pós desconto é de R$ {resultado}");

    }

    public static double Soma(double valor, double desconto)
    {
        double total = valor - desconto;

        return total;
    }


    public static void Exercicio2()
    {
        Console.WriteLine("-- EXERCÍCIO 02 --");
        Console.WriteLine("Informe o valor da compra:");
        double valor = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe o desconto em porcentagem:");
        double desconto = Convert.ToDouble(Console.ReadLine());

        double resultado = Desconto(valor, desconto);

        Console.WriteLine($"Compra finalizada! O total é de R$ {resultado}");
    }

    public static double Desconto(double valor, double desconto)
    {
        double total = valor - (valor * desconto / 100);

        return total;
    }

    public static void Exercicio3()
    {
        Console.WriteLine("-- EXERCÍCIO 03 --");
        Console.WriteLine("Informe o valor em quilos:");
        double kilos = Convert.ToDouble(Console.ReadLine());

        double gramas = Conversao(kilos);

        Console.WriteLine($"O valor em gramas é {gramas}");

    }

    public static double Conversao(double kilos)
    {
        double resultado = kilos * 1000;

        return resultado;
    }

    public static void Exercicio4()
    {
        Console.WriteLine("-- EXERCÍCIO 04 --");
        Console.WriteLine("Informe o valor em reais:");
        double reais = Convert.ToDouble(Console.ReadLine());

        double resultado = TaxaDeCambio(reais);

        Console.WriteLine($"O Valor convertido para dolar é de $ {resultado.ToString("0.00")}");

    }

    public static double TaxaDeCambio(double reais)
    {
        double dolar = reais / 5.16;

        return dolar;
    }

    public static void Exercicio5()
    {
        Console.WriteLine("-- EXERCÍCIO 05 --");
        Console.WriteLine("Informe o valor total da compra:");
        double total = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe o número de parcelas:");
        int parcelas = Convert.ToInt32(Console.ReadLine());

        double resultado = Parcelas(total, parcelas);

        Console.WriteLine($"Sua compra de R$ {total} em {parcelas}x de R$ {resultado} foi concluída");

    }

    public static double Parcelas(double total, int parcelas)
    {
        double valorParcela = total / parcelas;

        return valorParcela;
    }

    public static void Exercicio6()
    {
        Console.WriteLine("-- EXERCÍCIO 06 --");
        Console.WriteLine("Informe a capacidade do tanque (em litros):");
        int capacidade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe o consumo do veículo (km por litro):");
        int consumo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe a distância da viagem (em km):");
        int distancia = Convert.ToInt32(Console.ReadLine());

        int resposta = Capacidade(capacidade, consumo, distancia);

        Console.WriteLine($"Você precisará fazer {resposta} paradas para abastecer.");

    }

    public static int Capacidade(int capacidade, int consumo, int distancia)
    {
        int capacidadeViagem = capacidade * consumo;
        int paradas = (distancia - 1) / capacidadeViagem + 1;

        return paradas;
    }

    public static void Exercicio7()
    {
        Console.WriteLine("-- EXERCÍCIO 07 --");
        Console.WriteLine("Informe a quantidade de açaís:");
        int qtd = Convert.ToInt32(Console.ReadLine());

        double Resposta = Acai(qtd);

        Console.WriteLine($"Total a pagar é R$ {Resposta}");
    }

    public static double Acai(double qtd)
    {
        double total = qtd * 13.5;

        return total;
    }

    public static void Exercicio8()
    {
        Console.WriteLine("-- EXERCÍCIO 08 --");
        Console.WriteLine("Informe a quantidade de açaí pequeno:");
        int p = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe a quantidade de açaí médio:");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe a quantidade de açaí grande:");
        int g = Convert.ToInt32(Console.ReadLine());

        double resposta = Acaiteria(p, m, g);

        Console.WriteLine($"Total a pagar é R$ {resposta}");
    }

    public static double Acaiteria(int p, int m, int g)
    {
        double total = p * 13.5 + m * 15.0 + g * 17.5;

        return total;
    }

    public static void Exercicio9()
    {
        Console.WriteLine("-- EXERCÍCIO 09 --");
        Console.WriteLine("Informe a quantidade de açaí pequeno:");
        int p = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe a quantidade de açaí médio:");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe a quantidade de açaí grande:");
        int g = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe o desconto em porcentagem:");
        double desconto = Convert.ToDouble(Console.ReadLine());

        double resposta = Calculo(p, m, g, desconto);

        Console.WriteLine($"Total a pagar é R$ {resposta}");
    }

    public static double Calculo(int p, int m, int g, double desconto)
    {
        double subtotal = p * 13.5 + m * 15.0 + g * 17.5;
        double total = subtotal * (1 - desconto / 100);

        return total;
    }

    public static void Exercicio10()
    {
        Console.WriteLine("-- EXERCÍCIO 10 --");
        Console.WriteLine("Informe o salário base:");
        double baseSalario = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe o bônus em porcentagem:");
        double bonus = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe o desconto em reais:");
        double desconto = Convert.ToDouble(Console.ReadLine());
    }

    public static double Salario(double baseSalario, double bonus, double desconto)
    {
        double salarioLiquido = baseSalario + (baseSalario * bonus / 100) - desconto;

        return salarioLiquido;
    }

    public static void Exercicio01AD03()
    {
        Console.WriteLine("-- EXERCÍCIO 01 --");
        Console.WriteLine("Informe a temperatura em graus:");
        double temperatura = Convert.ToDouble(Console.ReadLine());

        bool resposta = Temperatura(temperatura);

        Console.WriteLine($"Você está com febre? {resposta}");
    }

    public static bool Temperatura(double temperatura)
    {
        if (temperatura >= 37.5)
        {
            Console.WriteLine("Você está com febre!");
            return true;
        }

        else
        {
            Console.WriteLine("Sua temperatura está normal.");
            return false;
        }
    }

    public static void Exercicio02AD03()
    {
        Console.WriteLine("-- EXERCÍCIO 02 --");
        Console.WriteLine("Informe a primeira nota:");
        double n1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe a segunda nota:");
        double n2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe a terceira nota:");
        double n3 = Convert.ToDouble(Console.ReadLine());

        double media = Media(n1, n2, n3);
        bool passou = Aprovado(media);

        Console.WriteLine($"A média do aluno é {media}");
        Console.WriteLine($"O aluno passou? {passou}");
    }

    public static double Media(double n1, double n2, double n3)
    {
        return (n1 + n2 + n3) / 3;
    }

    public static bool Aprovado(double media)
    {
        if (media >= 6)
        {
            Console.WriteLine("Aluno aprovado!");
            return true;
        }

        else
        {
            Console.WriteLine("Aluno reprovado!");
            return false;
        }
    }

    public static void Exercicio03AD03()
    {
        Console.WriteLine("-- EXERCÍCIO 03 --");
        Console.WriteLine("Informe a largura do primeiro retângulo:");
        double l1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe a altura do primeiro retângulo:");
        double a1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe a largura do segundo retângulo:");
        double l2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe a altura do segundo retângulo:");
        double a2 = Convert.ToDouble(Console.ReadLine());

        double area1 = CalcularArea(l1, a1);
        double area2 = CalcularArea(l2, a2);

        bool iguais = CompararAreas(area1, area2);

        Console.WriteLine($"O primeiro retângulo possui área {area1}.");
        Console.WriteLine($"O segundo retângulo possui área {area2}.");
        Console.WriteLine($"Eles são iguais? {iguais}");
    }

    public static double CalcularArea(double largura, double altura)
    {
        return largura * altura;
    }

    public static bool CompararAreas(double area1, double area2)
    {
        if (area1 == area2)
        {
            Console.WriteLine("As áreas são iguais!");
            return true;
        }

        else
        {
            Console.WriteLine("As áreas são diferentes!");
            return false;
        }
    }

    public static void Exercicio04AD03()
    {
        Console.WriteLine("-- EXERCÍCIO 04 --");
        Console.WriteLine("Informe um número:");
        int numero = Convert.ToInt32(Console.ReadLine());

        bool par = VerificarPar(numero);

        Console.WriteLine($"O número é par? {par}");
    }

    public static bool VerificarPar(int numero)
    {
        if (numero % 2 == 0)
        {
            Console.WriteLine("O número é par!");
            return true;
        }

        else
        {
            Console.WriteLine("O número é ímpar!");
            return false;
        }
    }


    public static void Exercicio05AD03()
    {
        Console.WriteLine("-- EXERCÍCIO 05 --");
        Console.WriteLine("Qual é o personagem de Friends que trabalha com TI?");
        string respostaUsuario = Console.ReadLine();

        bool correta = VerificarRespostaFriends(respostaUsuario);

        if (correta)
        {
            Console.WriteLine("Parabéns! Você acertou!");
        }
        else
        {
            Console.WriteLine("Resposta incorreta. Tente novamente!");
        }
    }

    public static bool VerificarRespostaFriends(string resposta)
    {
        if (resposta.ToLower() == "ross")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static void Exercicio06AD03()
    {
        Console.WriteLine("-- EXERCÍCIO 06 --");
        Console.WriteLine("Informe a cor do semáforo (Verde, Amarelo, Vermelho):");
        string cor = Console.ReadLine();

        bool podeAtravessar = VerificarSemaforo(cor);

        Console.WriteLine($"Pode atravessar? {podeAtravessar}");
    }

    public static bool VerificarSemaforo(string cor)
    {
        if (cor == "verde")
        {
            return true;
        }

        else
        {
            return false;
        }
    }

    public static void Exercicio07AD03()
    {
        Console.WriteLine("-- EXERCÍCIO 07 --");
        Console.WriteLine("Informe sua altura (em metros):");
        double altura = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe seu peso (em kg):");
        double peso = Convert.ToDouble(Console.ReadLine());

        double imc = CalcularIMC(peso, altura);
        bool acima = VerificarPeso(imc);

        Console.WriteLine($"Seu IMC é {imc}");
        Console.WriteLine($"Está acima do peso ideal? {acima}");
    }

    public static double CalcularIMC(double peso, double altura)
    {
        return peso / (altura * altura);
    }

    public static bool VerificarPeso(double imc)
    {
        if (imc >= 25.0)
        {
            Console.WriteLine("Você está acima do peso ideal.");
            return true;
        }

        else
        {
            Console.WriteLine("Seu peso está dentro do ideal.");
            return false;
        }
    }

    public static void Exercicio08AD03()
    {
        Console.WriteLine("-- EXERCÍCIO 08 --");
        Console.WriteLine("Informe o nome do livro:");
        string nome = Console.ReadLine();

        Console.WriteLine("Informe o total de páginas:");
        double paginas = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe o tempo de leitura por página (em segundos):");
        double tempoPorPagina = Convert.ToDouble(Console.ReadLine());

        double horas = CalcularTempoLeitura(paginas, tempoPorPagina);

        Console.WriteLine($"Você lerá {nome} em {horas} horas.");
    }

    public static double CalcularTempoLeitura(double paginas, double tempoPorPagina)
    {
        return (paginas * tempoPorPagina) / 3600;
    }

    public static void Exercicio09AD03()
    {
        Console.WriteLine("-- EXERCÍCIO 09 --");
        Console.WriteLine("Informe a capacidade do tanque (em litros):");
        double capacidade = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe a quantidade atual de combustível (em litros):");
        double atual = Convert.ToDouble(Console.ReadLine());

        bool precisaAbastecer = VerificarAbastecimento(capacidade, atual);

        if (precisaAbastecer)
        {
            Console.WriteLine("O carro precisa ser reabastecido.");
        }

        else
        {
            Console.WriteLine("O carro tem combustível suficiente.");
        }
    }

    public static bool VerificarAbastecimento(double capacidade, double atual)
    {
        return atual <= capacidade / 4;
    }


    public static void Exercicio10AD03()
    {
        Console.WriteLine("-- EXERCÍCIO 10 --");

        Console.WriteLine("Informe o diâmetro do primeiro cilindro:");
        double d1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe a altura do primeiro cilindro:");
        double h1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe o diâmetro do segundo cilindro:");
        double d2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe a altura do segundo cilindro:");
        double h2 = Convert.ToDouble(Console.ReadLine());

        double v1 = CalcularVolume(d1, h1);
        double v2 = CalcularVolume(d2, h2);

        Console.WriteLine($"O primeiro cilindro tem volume de {v1}");
        Console.WriteLine($"O segundo cilindro tem volume de {v2}");

        if (v1 <= v2)
        {
            Console.WriteLine("É possível transferir o primeiro para o segundo? true");
        }

        else
        {
            Console.WriteLine("É possível transferir o primeiro para o segundo? false");
        }
    }

    public static double CalcularVolume(double diametro, double altura)
    {
        double pi = 3.141592653589793;
        double raio = diametro / 2;

        return pi * raio * raio * altura;
    }

}