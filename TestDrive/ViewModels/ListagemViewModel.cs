using System;
using System.Collections.Generic;
using System.Text;
using TestDrive.Model;

namespace TestDrive.ViewModels
{
    public class ListagemViewModel
    {
        public List<Veiculo> Veiculos { get; set; }

        public ListagemViewModel()
        {
            this.Veiculos =  new ListagemVeiculo().Veiculos;
        }
    }
}
