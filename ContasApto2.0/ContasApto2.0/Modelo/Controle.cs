using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasApto2._0.Modelo
{
    public class Controle : absPropriedades
    {
        
        
        public Controle (String aluguel, String condominio, String energia, String gas, String telefone, String outros, String qtdMoradores)
        {

            if ((aluguel == "") || (condominio == "") || (energia == "") || (gas == "") || (telefone == "") || (outros == "") || (qtdMoradores == null))
            {
                this.respostaTotal = "";
                this.respostaPessoa = "";
            }
            else
            {
                this.dblAluguel = Convert.ToDouble(aluguel);
                this.dblCondominio = Convert.ToDouble(condominio);
                this.dblEnergia = Convert.ToDouble(energia);
                this.dblGas = Convert.ToDouble(gas);
                this.dblTelefone = Convert.ToDouble(telefone);
                this.dblOutros = Convert.ToDouble(outros);
                this.dblQtdMoradores = Convert.ToDouble(qtdMoradores);


                Executar();
            }

        }
        public void Executar()
        {
            Calcular calcular = new Calcular(this.dblAluguel, this.dblCondominio, this.dblEnergia, this.dblGas,this.dblTelefone, this.dblOutros, this.dblQtdMoradores);
            this.respostaPessoa = calcular.respostaPessoa;
            this.respostaTotal = calcular.respostaTotal;
            
        }
    }
}
