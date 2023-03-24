using Exemplo_Git.Interfaces;

namespace Exemplo_Git.Models
{
    public class Ornitorrinco
    {
            public int ID { get; set; }
            public string Nome { get; set; }
            public double Peso { get; set; }
            public double Altura { get; set; }

        public string PorteDoAnimal()
        {
            string porte = "";
            if (Altura >= .8)
            {
                porte = "Grande";
            }
            else if (Altura < .8 && Altura >= .4)
            {
                porte = "Médio";
            }
            else if (Altura < .4)
            {
                porte = "Pequeno";
            }
            return porte;
        }
    }
}
