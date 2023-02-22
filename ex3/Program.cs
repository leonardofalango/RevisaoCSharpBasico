using System;
using System.Linq;
using System.Collections.Generic;

var estoque = new List<Produto>()
{
    new Produto("Arroz", 10.0, new DateTime(2023, 12, 31)),
    new Produto("Feijão", 8.0, new DateTime(2023, 6, 30)),
    new Produto("Azeite", 20.0, new DateTime(2025, 2, 28)),
    new Produto("Sal", 2.0, new DateTime(2024, 10, 31)),
    new Produto("Açúcar", 5.0, new DateTime(2023, 8, 31)),
    new Produto("Café", 7.5, new DateTime(2022, 12, 31)),
    new Produto("Leite", 3.5, new DateTime(2023, 4, 30)),
    new Produto("Pão", 4.0, new DateTime(2022, 11, 30)),
    new Produto("Queijo", 15.0, new DateTime(2022, 10, 31)),
    new Produto("Presunto", 12.0, new DateTime(2022, 11, 30)),
    new Produto("Manteiga", 8.5, new DateTime(2023, 1, 31)),
    new Produto("Achocolatado", 6.0, new DateTime(2024, 5, 31)),
    new Produto("Refrigerante", 4.5, new DateTime(2023, 7, 31)),
    new Produto("Suco", 3.5, new DateTime(2023, 3, 31)),
    new Produto("Água", 2.0, new DateTime(2024, 2, 29)),
    new Produto("Carne", 25.0, new DateTime(2023, 2, 28)),
    new Produto("Frango", 15.0, new DateTime(2023, 1, 31)),
    new Produto("Peixe", 20.0, new DateTime(2022, 12, 31)),
    new Produto("Batata", 2.5, new DateTime(2022, 10, 31)),
    new Produto("Cebola", 3.0, new DateTime(2023, 3, 31)),
    new Produto("Alho", 2.0, new DateTime(2022, 11, 30)),
    new Produto("Tomate", 3.5, new DateTime(2023, 1, 28)),
    new Produto("Cenoura", 2.5, new DateTime(2023, 1, 31)),
    new Produto("Abóbora", 4.0, new DateTime(2024, 4, 30)),
    new Produto("Beterraba", 2.5, new DateTime(2023, 2, 19))
};


// 1 -Liste todos os produtos do estoque, do mais barato ao mais caro.
var lista = estoque.OrderBy(e => e.Valor);
Console.WriteLine("Ordenados por valor: ");
foreach (var item in lista)
    Console.WriteLine(item);


// 2 - Liste os produtos por ordem alfabética.
var listaNome = estoque.OrderBy(e => e.Nome);
Console.WriteLine("Ordenados por valor: ");
foreach (var item in listaNome)
    Console.WriteLine(item);


// 3 - Encontre a média de preço dos produtos, mostre a média, e todos os produtos com o preço acima dela
var valueMean = estoque.Average(e => e.Valor);
var greaterThanMean = estoque.Where(e => e.Valor >= valueMean);
foreach (var item in greaterThanMean)
    Console.WriteLine(item);

// 4 - Liste os produtos vencidos
var dayNow = DateTime.Now;
var expired = estoque.Where(e => e.DataValidade > dayNow);
foreach (var item in expired)
    Console.WriteLine(item);

// 5 - Implemente uma função que receba a lista de estoque e uma data utilizando o tipo DateTime, 
// esta função deve retornar uma lista que contendo todos os produtos que irão expirar até esta data
// Ex: WillExpirate(List<estoque> estoque, DateTime dataDesejada) { }
List<Produto> WillExpirate(List<Produto> estoque, DateTime dataFinal)
    => estoque.Where(e => e.DataValidade > dataFinal);

// 6 - Implemente uma função chamada valorMínimo, que tenha como parâmetro a lista de estoque e o valor mínimo
// que a lista deve filtrar, utilize o LINQ para retornar todos os valores acima do valorMínimo
// Ex: getByMinValue(List<estoque> estoque, double minValue)
List<Produto> getByMinValue(List<Produto> estoque, double minValue)
    => estoque.Where(e => e.Valor > minValue);

// 7 - Assim como no exercício 6, implemente agora uma função que pegue todos os valores menores que o valor máximo
// Ex: getByMaxValue(List<estoque> estoque, double maxValue)
List<Produto> getByMaxValue(List<Produto> estoque, double maxValue)
    => estoque.Where(e => e.Valor < maxValue);



public class Produto
{
    public string Nome { get; set; }
    public double Valor { get; set; }

    public DateTime DataValidade { get; set; }

    public Produto(string nome, double valor, DateTime validade)
    {
        Nome = nome;
        Valor = valor;
    }

    public override string ToString()
    {
        return Nome + " - R$ " + Valor;
    }
}