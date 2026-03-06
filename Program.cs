//Escriba un programa que pida números al usuario hasta ingresar 0 y al final muestre:

//la suma total de los números

//cuántos números se ingresaron

//el promedio de los números ingresados.

int num;
int suma = 0;
int contador = 0;
double promedio;


do
{

    Console.WriteLine("Ingrese un número");
    num = int.Parse(Console.ReadLine());
    if (num != 0)
    {
        suma = num + suma;
        contador++;

    }



} while (num != 0);

promedio = (double)suma / num;

Console.WriteLine("La suma total de los números es = " + suma);
Console.WriteLine("El total de número ingresador fue = " + contador);
Console.WriteLine("El promedio total es = " + promedio);

