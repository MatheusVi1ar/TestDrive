using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrive.Model
{
    public class ListagemVeiculo
    {
        public List<Veiculo> Veiculos = new List<Veiculo>()
            {
                new Veiculo { Nome = "Azure V6", Preco = 800.50 },
                new Veiculo { Nome = "Idea 2016", Preco = 97500 },
                new Veiculo { Nome = "Uninho zica", Preco = 354 }
            };
    }
}
