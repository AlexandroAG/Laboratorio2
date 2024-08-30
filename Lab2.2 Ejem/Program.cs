//Ejemplo1 

//Creación de Una Instancia 
MyClass object1 = new MyClass();    
object1.Nombre = "Yeison";
object1.Edad = 28;

//Asignación de Una Variable a otra 
MyClass object2 = object1

 //Este cambio de Propiedad afecta tanto al object1 comoel object2
 object2.Nombre = "Jose";

//Al imprimir la consola vemos que ambas propiedad imprimen José
Console.WriteLine(object2.Nombre);
Console.WriteLine(object1.Nombre);