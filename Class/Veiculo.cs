namespace PTI_POO
{

    public abstract class Veículo
    {
        protected double TaxaDiaria { get; set; }
        public abstract double CalcularValorTotal(int numDiarias);
    }

}