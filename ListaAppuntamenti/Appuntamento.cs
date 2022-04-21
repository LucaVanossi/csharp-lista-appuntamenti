using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAppuntamenti
{
    public class Appuntamento
    {
        public DateTime DataeOra;
        public string Nome ;
        public string localitaAppuntamento;

    
    public Appuntamento (DateTime DataeOra, string Nome, string localitaAppuntamento)
    {
        this.DataeOra = DataeOra;
        ControllaData();    
        this.Nome = Nome;
        this.localitaAppuntamento = localitaAppuntamento;
    }

     public void ControllaData()
        {
            if (this.DataeOra < DateTime.Now)
            {
                throw new InvalidTimeZoneException("Data non valida");
            }
        }
    
    }



}
