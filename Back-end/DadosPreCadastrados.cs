using System;

namespace Atividade04_Concessionaria
{
    // Classe que insere dados iniciais no sistema (pré-cadastrados)
		class Dados_PreCadastrados
		{
		    public static void InserirDadosIniciais(Cliente[] clientes, ref int contadorClientes,
		                                            Veiculos[] veiculos, ref int contadorVeiculos,
		                                            Vendedor[] vendedores, ref int contadorVendedores)
		    {
		        // Clientes padrão
		        clientes[contadorClientes++] = new Cliente() { Nome = "João Gouvea", CPF = "111.222.333-44", Numero = "11987654321" };
		        clientes[contadorClientes++] = new Cliente() { Nome = "Bernardo Diniz", CPF = "123.433.444-55", Numero = "11999998888" };
		        clientes[contadorClientes++] = new Cliente() { Nome = "Kaio Victor", CPF = "157.777.751-66", Numero = "11912345678" };
				
		        // Veículos padrão
		        veiculos[contadorVeiculos++] = new Veiculos() { Marca = "Chevrolet", Modelo = "Onix", Ano = 2021, Preco = 75000, Status = "Disponível" };
		        veiculos[contadorVeiculos++] = new Veiculos() { Marca = "Fiat", Modelo = "Argo", Ano = 2020, Preco = 68000, Status = "Disponível" };
		        veiculos[contadorVeiculos++] = new Veiculos() { Marca = "Volkswagen", Modelo = "Gol", Ano = 2019, Preco = 55000, Status = "Disponível" };
		        
		        // Vendedores padrão
				    vendedores[contadorVendedores++] = new Vendedor() { Nome = "Samuel Drumond", ID = "V001" };
				    vendedores[contadorVendedores++] = new Vendedor() { Nome = "Henrique Velame", ID = "V002" };
				    vendedores[contadorVendedores++] = new Vendedor() { Nome = "Mathias", ID = "V003" };
		    }
		}
}
