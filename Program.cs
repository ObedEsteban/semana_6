




using System.Security.Cryptography;

static string HideCharacter()
{
    ConsoleKeyInfo Key;
    string code = "";
    do
    {
        Key = Console.ReadKey(true);
        if (char.IsNumber(Key.KeyChar))


        {
            Console.Write("*");

        }
        code += Key.KeyChar;

    } while (Key.Key != ConsoleKey.Enter);
    return code;


}
HideCharacter();




















static void contraseña()

{

    byte Oportunidades, tienepermiso;
    string Clave;
    tienepermiso = 0;
    Oportunidades = 0;
    do
    {
        Console.Write("digite clave:");
        //Clave = Console.ReadLine();
        Clave = HideCharacter().Replace("\r", "");
        Console.WriteLine();

        if (Clave.ToUpper().Contains("A444"))
        {
            tienepermiso = 1;
        }
        else
        {
            Oportunidades++;
        }


    } while (((Oportunidades < 3) & (tienepermiso == 0)));

    if (tienepermiso == 1)
    {
        Console.WriteLine("bienvenido:" + Clave);
        desglose();
    }
    else
    {
        Console.WriteLine("oportunidades terminadas");

    }
    //Console.Write("pulsa una tecla:"); Console.ReadLine();
}
contraseña();









static void desglose()
{
    double dolar_a_quetzal = 7.75;
    double euro_a_quetzal = 9.25;


    Console.WriteLine("elija el tipo de moneda "); 
    Console.WriteLine("1. Dólar");
    Console.WriteLine("2. Euro");
    string moneda = Console.ReadLine();
    Console.Write("Ingresa la cantidad a convertir: ");
    double cantidad;
    while (!double.TryParse(Console.ReadLine(), out cantidad)) ;

    double resultado = 0;

    if (moneda == "1")
    {
        resultado = cantidad * dolar_a_quetzal;
        Console.WriteLine("{0} dólares equivalen a {1} quetzales", cantidad, resultado);
    }
    else if (moneda == "2")
    {
        resultado = cantidad * euro_a_quetzal;
        Console.WriteLine("{0} euros equivalen a {1} quetzales", cantidad, resultado);

    }
    int CAN = (int)resultado;
    int CAND = (int)((resultado - CAN) * 100);

    

    int c200, c100, c50, c20, c10, c5, c1;
    int m50, m25, m10, m5,m1;
    c200 = c100 = c50 = c20 = c10 = c5 = c1 =0;
    m50 = m25 = m10 = m5 = m1= 0;

   
    if (CAN >= 200)
    {
        c200 = (CAN / 200);
         CAN -= (c200 * 200);
    }
    if (CAN >= 100)
    {
        c100 = (CAN / 100);
        CAN -= (c100 * 100);
    }
    if (CAN >= 50)
    {
        c50 = (CAN / 50);
         CAN -= (c50 * 50);
    }
    if (CAN >= 20)
    {
        c20 = (CAN / 20);
         CAN -= (c20 * 20);
    }
    if (CAN >= 10)
    {
        c10 = (CAN / 10);
        CAN -= (c10 * 10);
    }
    if (CAN >= 5)
    {
        c5 = (CAN / 5);
         CAN -= (c5 * 5);
    }
    if (CAN >= 1)
    {
        c1 = (CAN / 1);
        CAN -= (c1 * 1);
    }
    // monedas
    if (CAND >= 50)
    {
        m50 = (CAND / 50);
         CAND -= (m50 * 50);
    }
    if (CAND >= 25)
    {
        m25 = (CAND / 25);
         CAND -= (m25 * 25);
    }
    if (CAND >= 10)
    {
        m10 = (CAND / 10);
         CAND -= (m10 * 10);
    }
    if (CAND >= 5)
    {
        m5 = (CAND / 5);
        CAND -= (m5 * 5);
    }
    if (CAND >= 1)
    {
        m1 = (CAND / 1);
        CAND -= (m1 * 1);
    }


    Console.WriteLine($"estos son tus billetes");
    Console.WriteLine($"billetes de a 200:{c200}");
    Console.WriteLine($"billetes de a 100:{c100}");
    Console.WriteLine($"billetes de a 50:{c50}");
    Console.WriteLine($"billetes de a 20:{c20}");
    Console.WriteLine($"billetes de a 10:{c10}");
    Console.WriteLine($"billetes de a 5:{c5}");
    Console.WriteLine($"billetes de a 1:{c1}");
    Console.WriteLine("");
    Console.WriteLine("Estas son tus Monedas ");
    Console.WriteLine($"Monedas de 50c = {m50}");
    Console.WriteLine($"Monedas de 25c = {m25}");
    Console.WriteLine($"Monedas de 10c = {m10}");
    Console.WriteLine($"Monedas de 5c = {m5}");
    Console.WriteLine($"Monedas de 1c = {m1}");

}
desglose();
//acepte billetes de 200
//deglose de monedas
//elija la moneda
//clave alfanumerica 


