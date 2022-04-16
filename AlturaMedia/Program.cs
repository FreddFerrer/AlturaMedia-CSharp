// See https://aka.ms/new-console-template for more information
Console.WriteLine("APLICACION DE CALCULO MEDIO DE ALTURA:");

Console.WriteLine("A continuacion digite la altura correspondiente a 10 personas (en cm):");


float[] alturas = new float[10];
float varianza = 0, desv_estandar = 0, media = 0, suma_valores = 0, desvio = 0;

//Guarda las alturas al array
for (int i = 0; i < alturas.Length; i++)
{
    int alturaPersona;

    Console.WriteLine("Altura persona " + (i + 1) + ": ");

    try
    {
        alturaPersona = int.Parse(Console.ReadLine());
        alturas[i] = alturaPersona;
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex);
        Console.WriteLine("Por favor introduzca una altura");
    }
}

//Sumar todas las alturas y calcular la media
for(int i = 0; i < alturas.Length; i++)
{
    suma_valores += alturas[i];
}

media = suma_valores / alturas.Length;

//Calcular la varianza para luego sacar mas facil la desviacion estandar
for(int i = 0; i < alturas.Length; i++)
{

    varianza = (float)(varianza + Math.Pow((alturas[i] - media), 2));
}
//desviacion estandar
desv_estandar = (float)Math.Sqrt(varianza / (alturas.Length - 1));

Console.WriteLine("*****************************");
Console.WriteLine("La media es: " + media);
Console.WriteLine("*****************************\n\n");


Console.WriteLine("*****************************");
Console.WriteLine("La desviacion estandar es: " + desv_estandar);
Console.WriteLine("*****************************\n\n");


//Calcular que persona tiene una altura mayor o menor a la media
for (int i = 0; i < alturas.Length; i++)
{
    if(alturas[i] < media)
    {
        Console.WriteLine("La persona " + (i+1) + " tiene una altura MENOR a la media");
    } else
    {
        Console.WriteLine("La persona " + (i + 1) + " tiene una altura MAYOR a la media");
    }
}

Console.WriteLine("\n\n****************************\n\n");

//Calcular la desviacion estandar de cada persona
for(int i = 0; i < alturas.Length; i++)
{
    desvio = (float)Math.Sqrt(varianza / (alturas[i] - 1));
    if(desvio > alturas[i])
    {
        Console.WriteLine("La persona " + (i + 1) + " se encuentra DENTRO del rango definido" +
            " por la desviacion estandar: " + desvio);

    } else
    {
        Console.WriteLine("La persona " + (i + 1) + " se encuentra FUERA del rango definido" +
            " por la desviacion estandar: " + desvio);
    }

}

