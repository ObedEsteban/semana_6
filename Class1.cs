using System.Security.Cryptography;

static string HideCharacter()// define una funcion la cual arrojara caracteres de tipo string 
{
    ConsoleKeyInfo Key;//es una funcion predeterminada
    string code = "";//es una cadena de caracteres vacia 
    do// comienzo del bucle do while, este bucle me indica que se repetira hasta precionar enter
    {
        Key = Console.ReadKey(true);// el true me sirve para ocultar la tecla que precione
        if (char.IsNumber(Key.KeyChar))// sirve para verificar si la tecla es un numero 


        {
            Console.Write("*");// no aparece el numero sino un asterisco

        }
        code += Key.KeyChar;// agrega la tecla presionada a la cadena code

    } while (Key.Key != ConsoleKey.Enter);// se cierra el bucle
    return code;// devulve la cadena code


}
HideCharacter(); // me llama a todo el proceso anteriior 




static void contraseña()

{

    byte Oportunidades, tienepermiso;// se utilizan para contar el numero de interntos 
    string Clave;// tipo string se utiliza para allmacenar la contraseña
    tienepermiso = 0;// se inicializa en o 
    Oportunidades = 0;// se inicializa en o 
    do// comienzo del bucle 
    {
        Console.Write("digite clave:");// imprime texto en pantalla
        //Clave = Console.ReadLine();
        Clave = HideCharacter().Replace("\r", "");//es la variable que definimos antes y me sirve para ocultar la clave
        Console.WriteLine();

        if (Clave.ToUpper().Contains("A444"))// verificamos que sea la contraseña 
        {
            tienepermiso = 1;// si la contraseña es correcta termina
        }
        else
        {
            Oportunidades++;//si es incorrecta aumenta de uno en uno hasta terminarlas
        }


    } while (((Oportunidades < 3) & (tienepermiso == 0)));// bucle 

    if (tienepermiso == 1)
    {
        Console.WriteLine("bienvenido:" + Clave);// si tiene permiso me arruja esto
        desglose();// y me manda a desglose que es mi siguiente codigo
    }
    else
    {
        Console.WriteLine("oportunidades terminadas");// de lo contrario esto

    }
    //Console.Write("pulsa una tecla:"); Console.ReadLine();
}
contraseña();// me llama a todo lo anterior 






static void desglose()
{
    double dolar_a_quetzal = 7.75;// crea una variable y asigna un valor
    double euro_a_quetzal = 9.25;// crea variable y asigna un valor


    Console.WriteLine("elija el tipo de moneda ");//imprime un texto 
    Console.WriteLine("1. Dólar");//imprime un texto
    Console.WriteLine("2. Euro");//imprime un texto
    string moneda = Console.ReadLine();// guarda la entrada del usuario en string 
    Console.Write("Ingresa la cantidad a convertir: ");//texto en pantalla
    double cantidad;// crea una variable 
    while (!double.TryParse(Console.ReadLine(), out cantidad)) ;//convierte la entrada en punto flotante  y lo guarda en cantidad

    double resultado = 0;// varible con valor 0

    if (moneda == "1")// si es igual a uno osea dolar 
    {
        resultado = cantidad * dolar_a_quetzal;//operacion 
        Console.WriteLine("{0} dólares equivalen a {1} quetzales", cantidad, resultado);//muestra el resultado
    }
    else if (moneda == "2")
    {
        resultado = cantidad * euro_a_quetzal;
        Console.WriteLine("{0} euros equivalen a {1} quetzales", cantidad, resultado);

    }
    int CAN = (int)resultado;// convierte el valor de resultado en entero y lo guarda en Can
    int CAND = (int)((resultado - CAN) * 100);// calcula la parte decimal y la converte en entero 



    int c200, c100, c50, c20, c10, c5, c1;// varibales enteras
    int m50, m25, m10, m5, m1;
    c200 = c100 = c50 = c20 = c10 = c5 = c1 = 0;// se inician en 0
    m50 = m25 = m10 = m5 = m1 = 0;// se inician en 0


    //logica 
    if (CAN >= 200)
    {
        c200 = (CAN / 200);
        CAN -= (c200 * 200);// si queda un residuo me evalua al siguiente hasta terminar mi numero
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
    Console.WriteLine($"billetes de a 200:{c200}");//imprime todo
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



