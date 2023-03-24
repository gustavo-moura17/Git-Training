using Exemplo_Git.Interfaces;
using System.Data;

namespace Exemplo_Git.Models
{
    public class Wallaby : IAnimal
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }

        public string PorteDoAnimal()
        {
            if(Altura >= .8)
            {
                return "Grande";
            }
            else if(Altura < .8 && Altura >= .4)
            {
                return "Médio";
            }
            else if(Altura < .4)
            {
                return "Pequeno";
            }

            throw new Exception("Essa exceção tá aqui para o VS parar de reclamar! Main");
        }
    }
}
