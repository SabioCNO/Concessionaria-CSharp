using System;

namespace Atividade04_Concessionaria
{
    // Classe que representa uma transação (venda, reserva ou aquisição)
		class Transacao
		{
		    public string Tipo; // Tipo de transação (Venda, Reserva, Aquisição)
		    public Cliente Cliente;
		    public Veiculos Veiculo;
		    public Vendedor Vendedor;
		    public string Data;
		}
}
