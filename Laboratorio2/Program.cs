//Definición de método que sumado 2 numeros e imprime su resultado
using Laboratorio2;

public void Sumar(int valor1, int valor2) //Definición de 2 numeros enteros
{

    int variableLocal = valor1 + valor2; //Almacena los 2 numeros enteros sumados
    Console.WriteLine(variableLocal); //Imprime el resultado de la suma

}



//Definición de método que sumado 2 numeros e imprime su resultado
public void Sumar(int valor1, int valor2) //Definición de 2 numeros enteros
{

    int variableLocal = valor1 + valor2; //Almacena los 2 numeros enteros sumados
    Console.WriteLine(variableLocal); //Imprime el resultado de la suma

}
Console.WriteLine(variableLocal); //Imprime error


using System;

namespace Laboratorio2
{
    class Program
    {
        static void Main(String[] args)
        {
            Client client = new Client();

            client.FistName = "Su_nombre";
            client.LastName = "Su_apellido";

            client.Age = 15;
            client.Id = 1;

            Console.WriteLine(client.GetFullName());

        }

    }

    public class Client
    {
        //Declarando variable de instancia clase 
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ushort Age { get; set; }

        public string GetFullName()
        {
            //Utilizando Variables de instancia de métodos dentro de una clase
            return FirstName + " " + LastName;
        }

    }

}


internal class Program
{
    private static void main(String[] args)
    {
        Client client = new Client();

        client.FistName = "Su_nombre";
        client.LastName = "Su_apellido";
        client.Age = 15;
        client.Id = 1;

        Console.WriteLine(client.GetFullName());

    }

}


public class MyClass
{
    //Declaración de Variable Estática
    public static int valor;
}


