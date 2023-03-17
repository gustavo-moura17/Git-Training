namespace Exemplo_Git.Interfaces
{
    public interface IAnimal
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }

        public abstract string PorteDoAnimal();
    }
}
