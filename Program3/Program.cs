using Program3;

int menu = 0;
while (true)
{
    try
    {
        Console.WriteLine($"\n1. Lanzar dados \n2. Salir del juego");
        menu = int.Parse(Console.ReadLine());
    }
    catch (Exception ex)
    {
        Console.WriteLine("Ingrese un numero valido");
        continue;
    }

    if (menu == 2)
        break;

    if (menu != 1)
        continue;

    Given given1 = new Given();
    Given given2 = new Given();
    Given given3 = new Given();

    Console.WriteLine($"\nNumeros de los dados: {given1.FacesGiven} - {given2.FacesGiven} - {given3.FacesGiven}");

    if (given1.FacesGiven == given2.FacesGiven && given2.FacesGiven == given3.FacesGiven)
    {
        Console.WriteLine("Gano");
        continue;
    } 
    else
    {
        Console.WriteLine("Perdio");
        continue;
    }
}