// Heurística #1 - Visibilidade:
// O sistema mostra em qual passo o usuário está ([Passo 1 de 3

// Heurística #3 - Controle:
// O usuário pode voltar ou cancelar 

// Heurística #9 - Erros:
// O sistema mostra mensagens de quando digita algo inválido.

bool voltou = false;

while (true) //LOOop
{
    voltou = false;

    // PASSO 1 - PRODUTO
    int codigo = 0;

    while (true)
    {
        Console.WriteLine("====================\n[Passo 1 de 3] - Produto\n====================");
        Console.WriteLine("1 - Produto-01\n2 - Produto-02\n3 - Produto-03");
        Console.WriteLine("Digite o código ou 'cancelar'");

        string input = Console.ReadLine()!;

        if (input == "cancelar")
        {
            Console.WriteLine("Pedido cancelado");
            return;
        }

        if (!int.TryParse(input, out codigo))
        {
            Console.WriteLine("Entrada inválida!");
            continue;
        }

        if (codigo < 1 || codigo > 3)
        {
            Console.WriteLine($"Código {codigo} não encontrado. Use valores de 1 a 3.");
            continue;
        }

        break;
    }

    //PASSO 2
    while (true)
    {
        int quantidade = 0;

        //PASSO 2 - qua,tidade 
        while (true)
        {
            Console.WriteLine("====================\n[Passo 2 de 3] - Quantidade\n====================");
            Console.WriteLine("Digite a quantidade ou 'voltar'");
             Console.WriteLine("Para sair digite 'cancelar'");

            string input = Console.ReadLine()!;

            if (input == "cancelar")
        {
            Console.WriteLine("Pedido cancelado");
            return;
        }

            if (input == "voltar")
            {
                voltou = true;
                break; // volta pro passo 1
            }

            if (!int.TryParse(input, out quantidade))
            {
                Console.WriteLine("Digite um número válido!");
                continue;
            }

            break;
        }

        if (voltou)
        {
            break;
        }

        //PASSO 3 confirmar 
        bool voltarParaPasso2 = false;

        while (true)
        {
            Console.WriteLine("====================\n[Passo 3 de 3] - Confirmação\n====================");
            Console.WriteLine($"Produto: {codigo} | Quantidade: {quantidade}");
            Console.WriteLine("Digite 'confirmar', 'voltar' ou 'cancelar'");

            string input = Console.ReadLine()!;

            if (input == "cancelar")
            {
                Console.WriteLine("Pedido cancelado");
                return;
            }

            if (input == "voltar")
            {
                voltarParaPasso2 = true;
                break;
            }

            if (input == "confirmar")
            {
                Console.WriteLine("Pedido finalizado!");
                return;
            }

            Console.WriteLine("Opção inválida!");
        }

        if (voltarParaPasso2)
        {
            continue; // volta pro passo 2
        }

        break;
    }

    if (voltou)
    {
        continue; // volta pro passo 1
    }

    break; 
}