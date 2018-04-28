using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasApto2._0.Modelo
{
    public class Calcular : absPropriedades
    {
        public Calcular(Double dblAluguel, Double dblCondominio, Double dblEnergia, Double dblGas, Double dblTelefone, Double dblOutros, Double dblQtdMoradores)
        {
            this.dblAluguel = dblAluguel;
            this.dblCondominio = dblCondominio;
            this.dblEnergia = dblEnergia;
            this.dblGas = dblGas;
            this.dblTelefone = dblTelefone;
            this.dblOutros = dblOutros;
            this.dblQtdMoradores = dblQtdMoradores;

            Somar();
        }
        public void Somar ()
        {
            this.pessoa = (this.dblAluguel + this.dblCondominio + this.dblEnergia + this.dblGas + this.dblTelefone + this.dblOutros) / (this.dblQtdMoradores);
            this.total = this.dblAluguel + this.dblCondominio + this.dblEnergia + this.dblGas + this.dblTelefone + this.dblOutros;

            this.respostaPessoa = this.pessoa.ToString("N2");
            this.respostaTotal = this.total.ToString("N2");
        }
    }
}
