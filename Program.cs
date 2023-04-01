
using System;

void matriz()
{
    String [] nombre = new String[]
    {
        "Anderson","Brandon","Yeimi","Fatima","Vivian"
    };

    //Recorrer todo el arreglo sin for
    foreach (string n in nombre)
    {
    Console.WriteLine("Nombre="+n);
    }
    
    int[] notas = new int[]
    {
        51,80,96,76,61
    };
    
    int promedio = 0;
    foreach(int n in notas)
    {
        promedio=promedio+n;
    }
    
    promedio = promedio / notas.Length;
    Console.WriteLine("El promedio ="+promedio);

    int mayor = 0;
    string nombredemayor="";

    for (int i = 0; i < notas.Length; i++)
    {
        if (mayor < notas[i])
        {
            mayor = notas[i];
            nombredemayor = nombre[i];
        }
    }

    Console.WriteLine("Mayor: "+mayor);
    Console.WriteLine("Nombre: "+nombredemayor);
}


matriz();
