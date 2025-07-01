namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public Reserva (int dias)
        {
            DiasReservados = dias;
        }

        public int DiasReservados { get; set; }
        public List<Pessoa> Hospedes { get; set; } 
        public Suite SuiteReservada { get; set; }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if(hospedes.Count <= 0)
            {
                throw new Exception("Quantidade de hóspedes não pode ser menor que zero.");
            } else if (hospedes.Count > SuiteReservada.Capacidade)
            {
                throw new Exception("Quantidade de hóspedes excede a quantidade da suíte.");
            }
            {
                Hospedes = hospedes;
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            SuiteReservada = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal totalAPagar = SuiteReservada.ValorDiaria * DiasReservados;
            if(DiasReservados >= 10)
            {
                totalAPagar *= 0.9m;
            }
            return totalAPagar;
        }
    }
}
