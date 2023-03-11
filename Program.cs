// See https://aka.ms/new-console-template for more information


//Ejercicio 1
Console.WriteLine("Ingrese su nombre");
string nombre = Console.ReadLine();
Console.WriteLine("Su nombre es " + nombre);

Console.ReadKey();
Console.Clear();

//Ejercicio 2

string datetime = DateTime.Now.ToString("hh:mm:ss tt");

Console.WriteLine(datetime);
