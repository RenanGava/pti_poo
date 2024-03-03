namespace PTI_POO
{


  class Moto : Veículo
  {


    public Moto(double taxaDiaria)
    {
      this.TaxaDiaria = taxaDiaria;
    }

    public override double CalcularValorTotal(int numDiarias)
    {
      if (numDiarias <= 0)
      {
        throw new Exception("Quantidade de Diaria Invállida");
      }
      else
      {
        return numDiarias * this.TaxaDiaria;
      }
    }
  }
}