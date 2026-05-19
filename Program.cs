// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);

int num, invertido=0;
string entrada;
Console.WriteLine("Ingrese un numero:");
entrada=Console.ReadLine();

while(!int.TryParse(entrada, out num)){
    Console.WriteLine("Error no es un numero");
    Console.WriteLine("Ingrese un número nuevamente:");
    entrada=Console.ReadLine();
}

while(num > 0){
    int ultimo= num%10;
    invertido = (invertido * 10) + ultimo;
    num = num /10;
}

Console.WriteLine("Numero invertido:"+invertido);