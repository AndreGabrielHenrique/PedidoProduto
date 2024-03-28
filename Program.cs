﻿/*Crie um programa que receba o pedido de um produto com nome, preço e quantidade.
Considere que de acordo com a quantidade solicitada o comprador receberá um desconto sobre o valor total.
O programa deve mostrar na tela o valor total do produto após ser registrado o pedido.
* Até 10 unidades: valor total 
* de 11 a 20 unidades: 10% de desconto
* de 21 a 50 unidades: 20% de desconto 
* acima de 50 unidades: 25% de desconto*/
using System.Numerics;

string sep=new string('-',134);
string nome;
double preco;
int unidade;
System.Console.WriteLine(sep);
System.Console.WriteLine("Nome do produto");
nome=Console.ReadLine();
System.Console.WriteLine("Preço do produto");
preco=double.Parse(Console.ReadLine());
System.Console.WriteLine("Quantidade de unidades do produto");
unidade=int.Parse(Console.ReadLine());
System.Console.WriteLine(sep);
if(unidade<=10)
{
    double total=preco*unidade;
    System.Console.WriteLine($"Você comprou {unidade} unidades de {nome}, que custa {preco:c} cada um e no total ficou {total:c}.\n{sep}");
}
else if(unidade>=11&&unidade<=20)
{
    double total=preco*unidade;
    double desconto=total*0.10;
    System.Console.WriteLine($"Você comprou {unidade} unidades de {nome}, que custa {preco:c} cada um e no total ficou {total:c}, com 10% de desconto ficou tudo {desconto:c}\n{sep}.");
}
else if(unidade>=21&&unidade<=50)
{
    double total=preco*unidade;
    double desconto=total*0.20;
    System.Console.WriteLine($"Você comprou {unidade} unidades de {nome}, que custa {preco:c} cada um e no total ficou {total:c}, com 20% de desconto ficou tudo {desconto:c}\n{sep}.");
}
else if(unidade>=51)
{
    double total=preco*unidade;
    double desconto=total*0.25;
    System.Console.WriteLine($"Você comprou {unidade} unidades de {nome}, que custa {preco:c} cada um e no total ficou {total:c}, com 25% de desconto ficou tudo {desconto:c}\n{sep}.");
}