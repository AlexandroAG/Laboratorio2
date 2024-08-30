
using System;

namespace Laboratorio21
{

    public class Program
    {
        public static void main(string[] args)
        {
            //Asignación a Variable Estática
            MyClass.valor = 1;
            Console.WriteLine(MyClass.valor);
        
        }

    }

    public class MyClass 
    {
        //Declaración de variable estática
        public static int valor;
    
    }

}
