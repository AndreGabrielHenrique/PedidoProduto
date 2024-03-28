class Produto
{
    public string sep=new string('-',134);
    public string nome;
    public double preco;
    public int unidade;
    public void CalcularPreco()
    {
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
    }
}