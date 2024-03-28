﻿﻿/*Crie um programa que receba o pedido de um produto com nome, preço e quantidade.
Considere que de acordo com a quantidade solicitada o comprador receberá um desconto sobre o valor total.
O programa deve mostrar na tela o valor total do produto após ser registrado o pedido.

* Até 10 unidades: valor total 
* de 11 a 20 unidades: 10% de desconto
* de 21 a 50 unidades: 20% de desconto 
* acima de 50 unidades: 25% de desconto*/
Produto novoproduto=new Produto();
System.Console.WriteLine(novoproduto.sep);
System.Console.WriteLine("Nome do produto");
novoproduto.nome=Console.ReadLine();
System.Console.WriteLine("Preço do produto");
novoproduto.preco=double.Parse(Console.ReadLine());
System.Console.WriteLine("Quantidade de unidades do produto");
novoproduto.unidade=int.Parse(Console.ReadLine());
System.Console.WriteLine(novoproduto.sep);
novoproduto.CalcularPreco();