// See https://aka.ms/new-console-template for more information
using ConsoleApp_Noite;
using ConsoleApp_Noite.Heranca;
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");

Produto p1 = new Produto(1, 10.90M, "Cervejinha");

Console.WriteLine(p1.getDescricao() + "" + p1.getId());

p1.setValor(11.85M);
p1.setDescricao("Cerveja Skol 1 litrão");

Console.WriteLine(p1.getDescricao() + "" + p1.getValor());

Endereco endereco = new Endereco(
    "Rua Mario Miziara",
    "91",
    "Sobral",
    "15811223",
    "Taquaritinga",
    "SP");



Cliente c1 = new Cliente(1, "Arthur", "9972662539", endereco);
Cliente c2 = new Cliente(2, "Fernando", "9971662539", endereco);
Cliente c3 = new Cliente(3, "Felippe", "9972662579", endereco);
Cliente c4 = new Cliente(4, "Leandro", "9972662539", endereco);
Cliente c5 = new Cliente(5, "Amanda", "9972562539", endereco);


Console.WriteLine (c2.getEndereco().getRua() + "" + c2.getEndereco().getNumero());

c2.getEndereco().setNumero("135");




Carro gol = new Carro();
gol.temMotor = true;
gol.numeroPortas = 4;
gol.numeroAssentos = 5;

Bike caloi = new Bike();
caloi.temMotor = false;
caloi.numeroPortas = 0;
caloi.numeroAssentos = 1;

gol.fabricante = "VW";
gol.cintoSeguranca = true;
gol.arCondicionado = false;

Carro Saveiro = new Carro();
Carro Palio = new Carro();
Carro Uno = new Carro();

Saveiro.fabricante = "VW";
Palio.fabricante = "Fiat";
Uno.fabricante = "Fiat";

Bike speed = new Bike();
speed.temMotor = false;
speed.numeroAssentos = 1;

Console.WriteLine(speed.ExibirDados());
Console.WriteLine(gol.ExibirDados());

