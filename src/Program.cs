using src.Entities;

Knight knight = new Knight("Arus", "Cavaleito", 42, "469 / 749", "72 / 72");
Wizard whiteWizard = new Wizard("Jenica", "Maga Branca", 42, "325 / 601", "474 / 482");
Ninja ninja = new Ninja("Wedge", "Ninja", 42, "292 / 574", "89 / 89");
Wizard blackWizard = new Wizard("Topapa", "Mago Negro", 42, "106 / 385", "611 / 641");


Console.WriteLine("Olá! Deseja conhecer o seu herói favorito?\n");
Console.WriteLine("Digite o número que correponde ao herói desejado: 1-Arus | 2-Janica | 3-Wedge | 4-Topapa \n");

int chooseUser = int.Parse(Console.ReadLine());


if (chooseUser > 0 && chooseUser < 5)
{
    switch (chooseUser)
    {
        case 1:
            knight.Presentation();
            break;

        case 2:
            whiteWizard.Presentation();
            break;

        case 3:
            ninja.Presentation();
            break;

        case 4:
            blackWizard.Presentation();
            break;
    }
}
else
{
    Console.WriteLine("Valor inválido. Pressione [Enter] para Sair.");
    Console.ReadKey();
}


if (chooseUser > 0 && chooseUser < 5)
{
    Console.WriteLine("Deseja realizar um ataque com o seu herói? \n");
    Console.WriteLine("Pressione [Enter] para atacar --->");
    Console.ReadLine();

    switch (chooseUser)
    {
        case 1:
            Console.WriteLine(knight.Attack());
            break;

        case 2:
            Console.WriteLine(whiteWizard.Attack());
            break;

        case 3:
            Console.WriteLine(ninja.Attack());
            break;

        case 4:
            Console.WriteLine(blackWizard.Attack());
            break;

        default:
            Console.WriteLine("Ataque bem sucedido");
            Console.ReadKey();
            break;            
    }
}

