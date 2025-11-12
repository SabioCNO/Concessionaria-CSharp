
using System;

namespace Atividade04_Concessionaria
{
		// Classe que representa um cliente da concessionária
		class Cliente
		{
			public string Nome;
	    	public string CPF;
	    	public string Numero;
		}
	
		// Classe que representa um veículo
		class Veiculos
		{
			public string Marca;
			public string Modelo;
			public int Ano;
			public double Preco;
			public string Status;
		}
	
		// Classe que representa um vendedor
		class Vendedor
		{
		    public string Nome;
		    public string ID;
		}
	
		// Classe que representa uma transação (venda, reserva ou aquisição)
		class Transacao
		{
		    public string Tipo; // Tipo de transação (Venda, Reserva, Aquisição)
		    public Cliente Cliente;
		    public Veiculos Veiculo;
		    public Vendedor Vendedor;
		    public string Data;
		}
	
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
	
		class Program
		{
			// Arrays que armazenam os dados
			static Cliente[] clientes = new Cliente[10];
			static int contadorClientes = 0;
			
			static Veiculos[] veiculos = new Veiculos[10];
			static int contadorVeiculos = 0;
			
			static Vendedor[] vendedores = new Vendedor[10];
			static int contadorVendedores = 0;
	
			// Array que guarda todas as transações realizadas
			static Transacao[] transacoes = new Transacao[20];
			static int contadorTransacoes = 0;
			
		public static void Main(string[] args)
		{
			// Insere dados iniciais automaticamente
			Dados_PreCadastrados.InserirDadosIniciais(clientes, ref contadorClientes, veiculos, ref contadorVeiculos, vendedores, ref contadorVendedores);
			
			string Usuario, Senha;
			Console.Clear();
            Console.WriteLine("========================= LOGIN =========================");
            
            bool Login = false;
            
            // Loop de login — só continua se usuário e senha forem corretos
            while (!Login) 
            {
                Console.Write("\nDigite o seu nome de usuário:");
                Usuario = Console.ReadLine().ToLower();
                Console.Write("\nDigite a sua senha:");
                Senha = Console.ReadLine().ToLower();
                
                // Verificação simples de login
                if(Usuario == "rubens" && Senha == "12345")
                {
                	Console.Clear();
                    Console.WriteLine("Login efetuado com sucesso!!, Bem vindo Rubens");
                    Login = true;
                    
                    // Abre o menu principal do sistema
                    MenuPrincipal();
                }
                else if(Usuario == "rubens" || Senha != "12345")
                {
                    Console.WriteLine("Senha incorreta. Tente novamente.");
                }
                else if(Usuario != "rubens" || Senha == "12345")
                {
                    Console.WriteLine("Usuário incorreto. Tente novamente.");
                }
                else if(Usuario == "" || Senha == "")
                {
                    Console.WriteLine("Campos vazios. Digite o usuário e a senha.");
                }
            }

            Console.WriteLine("=========================================================");
            Console.ReadKey();
        }
        
        public static void MenuPrincipal()
        {
        	bool continuar = true;
        	while(continuar)
        	{
        		Console.Clear();
	            Console.WriteLine("========================= MENU PRINCIPAL =========================");
	            Console.WriteLine("1 - Gerenciar os Clientes");
	            Console.WriteLine("2 - Gerenciar veículos");
	            Console.WriteLine("3 - Gerenciar transações");
	            Console.WriteLine("4 - Gerenciar Vendedores");
	            Console.WriteLine("5 - Sair");
	            Console.WriteLine("===================================================================");
	            Console.WriteLine("Escola um dos elementos do menu para prossesguir:");
	            string escolha = Console.ReadLine();
	            
	            // Switch que controla as opções do menu principal
	            switch (escolha) 
	            {
	                case "1":
	                    GerenciarClientes();
	                    break;
	                    
	                case "2":
	                    GerenciarVeiculos();
	                    break;
	                    
	                case "3":
	                    GerenciarTransacoes();
	                    break;    
	                    
	                case "4":
	                    GerenciarVendedores();
	                    break; 
	
	                case "5":
	                    Console.WriteLine("\nSaindo...");
	                	continuar = false;
	                    break;
	
	                default:
	                    Console.WriteLine("Ouve um erro!, digite uma opção válida");
	                    break;                    
	            }
            
            		Console.ReadKey();    
         	}
        }
        
        public static void GerenciarClientes() 
        {
        	bool continua = true;
        	while(continua)
        	{
	            Console.Clear();
	            Console.WriteLine("======================= GERENCIAR CLIENTES =======================");
	            Console.WriteLine("1 - Cadastrar Cliente");
	            Console.WriteLine("2 - Listar CLientes");
	            Console.WriteLine("3 - Voltar");
	            Console.WriteLine("===================================================================");
	            string escolha = Console.ReadLine();
	             
	            // Switch para submenu de clientes
	            switch(escolha)
	            {
	                case "1":
	                    CadastrarCliente();
	                    break;
	                    
	                case "2":
	                    ListarClientes();
	                    break;
	                    
	                case "3":
	                    continua = false;
	                    break;
	                    
	                default:
	                    Console.WriteLine("Ouve um erro!, digite uma opção válida");
	                    break;
	            }
        	}
        }
        
        public static void GerenciarVeiculos()
        {
            bool Continua = true;
            
            while(Continua)
            {
                Console.Clear();
                Console.WriteLine("======================= GERENCIAR VEÍCULOS ========================");
                Console.WriteLine("1 - Cadastrar veiculo");
                Console.WriteLine("2 - Listar veiculos disponiveis");
                Console.WriteLine("3 - Voltar");
                Console.WriteLine("===================================================================");
                Console.Write("Escolha uma opção: ");
                string escolha = Console.ReadLine();
                 
                // Switch para submenu de veículos
                switch(escolha)
                {
                    case "1":
                        CadastrarVeiculo();
                        break;
                        
                    case "2":
                        ListarVeiculosDisponiveis();
                        break;
                        
                    case "3":
                        Continua = false;
                        break;
                        
                    default:
                        Console.WriteLine("Ouve um erro!, digite uma opção válida");
                        break;
                }
            }
        }
        
        public static void GerenciarTransacoes()
        {
        	
        	bool Continuar = true;
        	
        	while (Continuar)	
        	{
        		Console.Clear();
	            Console.WriteLine("======================= GERENCIAR TRANSAÇÕES =======================");
	            Console.WriteLine("1 - Registrar Venda");												
	            Console.WriteLine("2 - Registrar Reserva");												
	            Console.WriteLine("3 - Registrar Aquisição (compra da concessionária)");				
	            Console.WriteLine("4 - Listar atividades");												
	            Console.WriteLine("5 - Voltar");														
	            Console.WriteLine("====================================================================");
	            Console.Write("Escolha uma opção: ");
	            string escolha = Console.ReadLine();
	            
	            // Switch para submenu de transações
	            switch(escolha)
	            {
	                case "1":
	                     RegistrarTransacao("Venda");
	                    break;
	                    
	                case "2":
	                   	RegistrarTransacao("Reserva");
	                    break;
	                    
	                case "3":
	                     RegistrarTransacao("Aquisição");
	                    break;
	                    
	                case "4":
	                     ListarTransacoes();
	                    break;  
	                    
	                case "5":
	                    Continuar = false;
	                    break;
	                    
	                default:
	                    Console.WriteLine("Opção inválida!!!");
	                    Console.WriteLine("Escolha uma das opções listadas");
	                    break;
	            } 
        	}
        }
        
        public static void GerenciarVendedores()
		{
		    bool continua = true;
		
		    while (continua)
		    {
		        Console.Clear();
		        Console.WriteLine("======================= GERENCIAR VENDEDORES =======================");
		        Console.WriteLine("1 - Cadastrar Vendedor");
		        Console.WriteLine("2 - Listar Vendedores");
		        Console.WriteLine("3 - Voltar");
		        Console.WriteLine("====================================================================");
		        Console.Write("Escolha uma opção: ");
		        string escolha = Console.ReadLine();
		
		        switch (escolha)
		        {
		            case "1":
		                CadastrarVendedor();
		                break;
		
		            case "2":
		                ListarVendedor();
		                break;
		
		            case "3":
		                continua = false;
		                break;
		
		            default:
		                Console.WriteLine("Opção inválida, tente novamente!");
		                Console.ReadKey();
		                break;
		        }
		    }
		}
        
        public static void RegistrarTransacao(string tipo)
        {
        	Console.Clear();
        	Console.WriteLine("=============== REGISTRO DE TRANSAÇÕES ===============\n");
        	 
        	// Verifica se há clientes e veículos cadastrados
		    if (contadorClientes == 0 || contadorVeiculos == 0)
		    {
		        Console.WriteLine("Erro!!.");
		        Console.WriteLine("É necessário ter pelo menos um cliente e um veículo cadastrado!\n");
		        Console.ReadKey();
		        return;
		    }
		
		    // Lista clientes disponíveis
		    Console.WriteLine("\nClientes cadastrados:");
		    for (int i = 0; i < contadorClientes; i++)
		    {
		        Console.WriteLine("{0} - {1} (CPF: {2})", i + 1, clientes[i].Nome, clientes[i].CPF);
		    }
		
		    Console.Write("\nEscolha o número do cliente: ");
		    int indiceCliente = int.Parse(Console.ReadLine()) - 1;
		
		    // Lista veículos disponíveis
		    Console.WriteLine("\nVeículos disponíveis:");
		    for (int i = 0; i < contadorVeiculos; i++)
		    {
		        if (veiculos[i].Status == "Disponível")
		        {
		            Console.WriteLine("{0} - {1} {2} (Ano: {3})", i + 1, veiculos[i].Marca, veiculos[i].Modelo, veiculos[i].Ano);
		        }
		    }
		
		    Console.Write("\nEscolha o número do veículo: ");
		    int indiceVeiculo = int.Parse(Console.ReadLine()) - 1;
		
		    // Lista os vendedores cadastrados
			Console.WriteLine("\nVendedores disponíveis:");
			for (int i = 0; i < contadorVendedores; i++)
			{
			    Console.WriteLine("{0} - {1} (ID: {2})", i + 1, vendedores[i].Nome, vendedores[i].ID);
			}
			
			Console.Write("\nEscolha o número do vendedor responsável: ");
			int indiceVendedor = int.Parse(Console.ReadLine()) - 1;
			
			// Armazena o vendedor selecionado
			Vendedor vendedor = vendedores[indiceVendedor];
		
		    // Cria a transação
		    Transacao nova = new Transacao();
		    nova.Tipo = tipo;
		    nova.Cliente = clientes[indiceCliente];
		    nova.Veiculo = veiculos[indiceVeiculo];
		    nova.Vendedor = vendedor;
		    nova.Data = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
		
		    // Armazena
		    transacoes[contadorTransacoes] = nova;
		    contadorTransacoes++;
		
		    // Atualiza o status do veículo
		    if (tipo == "Venda")
		    {
		        veiculos[indiceVeiculo].Status = "Vendido";
		    }
		    else if (tipo == "Reserva")
		    {
		        veiculos[indiceVeiculo].Status = "Reservado";
		    }
		    else
		    {
		        veiculos[indiceVeiculo].Status = "Comprado pela concessionária";
		    }
		
		    Console.WriteLine("\nTransação registrada com sucesso!");
		    Console.ReadKey();
		}
       
        public static void ListarTransacoes()
        { 	
		    Console.Clear();
		    Console.WriteLine("=============== LISTA DE TRANSAÇÕES ===============\n");
		
		    if (contadorTransacoes == 0)
		    {
		        Console.WriteLine("Nenhuma transação registrada ainda!");
		    }
		    else
		    {
		        for (int i = 0; i < contadorTransacoes; i++)
		        {
		            Console.WriteLine("Transação {0}:", i + 1);
		            Console.WriteLine("Tipo: {0}", transacoes[i].Tipo);
		            Console.WriteLine("Cliente: {0}", transacoes[i].Cliente.Nome);
		            Console.WriteLine("Veículo: {0} {1} - Ano {2}", transacoes[i].Veiculo.Marca, transacoes[i].Veiculo.Modelo, transacoes[i].Veiculo.Ano);
		            Console.WriteLine("Vendedor: {0}", transacoes[i].Vendedor.Nome);
		            Console.WriteLine("Data: {0}", transacoes[i].Data);
		            Console.WriteLine("--------------------------------------");
		        }
		    }
		
		    Console.ReadKey();
        }
        
        public static void CadastrarVeiculo()
        {
            Console.Clear();
            Console.WriteLine("=============== CADASTRAR NOVO VEÍCULO ===============");
    		
            Veiculos novo = new Veiculos();
            
            Console.Write("Digite a marca do carro que queira cadastrar: ");
 			novo.Marca = Console.ReadLine();
        
            Console.Write("\nDigite o modelo do carro que deseja cadastrar: ");
            novo.Modelo = Console.ReadLine();
        
            Console.Write("\nDigite o ano que deseja cadastrar a esse veículo: ");
            novo.Ano = int.Parse(Console.ReadLine());
            
            Console.Write("\nDigite o preço que deseja inserir nesse veículo: ");
          	novo.Preco = double.Parse(Console.ReadLine());
          	
          	novo.Status = "Disponível"; // Todo carro novo começa disponível
          	
             // Armazena o veículo no array
		    veiculos[contadorVeiculos] = novo;
		    contadorVeiculos++;
           
            Console.WriteLine("Veículo cadastrado com sucesso!");
            Console.ReadKey();

        }
        
        public static void ListarVeiculosDisponiveis()
        {
        	Console.Clear();
		    Console.WriteLine("=============== LISTA DE VEÍCULOS ===============\n");
			
		     if (contadorVeiculos == 0)
		    {
		        Console.WriteLine("Nenhum cliente cadastrado ainda!");
		    }
		    else
		    {
		        for (int i = 0; i < contadorVeiculos; i++)
		        {
		        	Console.WriteLine("Marca: {0}", veiculos[i].Marca);
		            Console.WriteLine("Modelo:{0}", veiculos[i].Modelo);
		            Console.WriteLine("Ano:{0}", veiculos[i].Ano);
		            Console.WriteLine("Preço: R${0}", veiculos[i].Preco);
		            Console.WriteLine("Status: {0}",veiculos[i].Status);
		            Console.WriteLine("--------------------------------------");
		        }
		    }
		    
		    Console.ReadKey();
        }

        public static void CadastrarCliente()
        {
            Console.Clear();
            Console.WriteLine("=============== CADASTRAR CLIENTE ===============");
            Console.Write("\n");
            
            Cliente novo = new Cliente(); 
		
		    Console.Write("Digite o nome do cliente: ");
		    novo.Nome = Console.ReadLine();
		
		    Console.Write("Digite o CPF do cliente: ");
		    novo.CPF = Console.ReadLine();
		
		    Console.Write("Digite o número do cliente: ");
		    novo.Numero = Console.ReadLine();

   			// Guarda o cliente no array
    		clientes[contadorClientes] = novo;
    		contadorClientes++;
           
            Console.WriteLine("\nCliente cadastrado com sucesso!");
            
            Console.Write("\n");
            Console.WriteLine("=================================================");
            Console.Write("\n");
            
            Console.ReadKey();
        } 

		public static void ListarClientes()
		{
		    Console.Clear();
		    Console.WriteLine("=============== LISTA DE CLIENTES ===============\n");
			
		     if (contadorClientes == 0)
		    {
		        Console.WriteLine("Nenhum cliente cadastrado ainda!");
		    }
		    else
		    {
		        for (int i = 0; i < contadorClientes; i++)
		        {
		            Console.WriteLine("Cliente: {0}", i + 1);
		            Console.WriteLine("Nome:{0}", clientes[i].Nome);
		            Console.WriteLine("CPF:{0}", clientes[i].CPF);
		            Console.WriteLine("Número:{0}", clientes[i].Numero);
		            Console.WriteLine("--------------------------------------");
		        }
		    }
		    
		    Console.ReadKey();
		}
		
		public static void CadastrarVendedor()
		{
		    Console.Clear();
		    Console.WriteLine("=============== CADASTRAR VENDEDOR ===============");
		
		    Vendedor novo = new Vendedor();
		
		    Console.Write("Digite o nome do vendedor: ");
		    novo.Nome = Console.ReadLine();
		
		    Console.Write("Digite o ID do vendedor: ");
		    novo.ID = Console.ReadLine();
		
		    //Guarda o vendedor num array
		    vendedores[contadorVendedores] = novo;
		    contadorVendedores++;
		
		    Console.WriteLine("\nVendedor cadastrado com sucesso!");
		    Console.ReadKey();
		}
		
		public static void ListarVendedor()
		{
			Console.Clear();
		    Console.WriteLine("=============== LISTA DE VENDEDOR ===============\n");
			
		     if (contadorVendedores == 0)
		    {
		        Console.WriteLine("Nenhum vendedor cadastrado ainda!");
		    }
		    else
		    {
		        for (int i = 0; i < contadorVendedores; i++)
		        {
		            Console.WriteLine("Vendedor: {0}", i + 1);
           			Console.WriteLine("Nome: {0}", vendedores[i].Nome);
            		Console.WriteLine("ID: {0}", vendedores[i].ID);
		            Console.WriteLine("--------------------------------------");
		        }
		    }
		    
		    Console.ReadKey();
		}
	}
}
