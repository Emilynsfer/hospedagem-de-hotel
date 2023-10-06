namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {

        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }



        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new ArgumentException("A quantidade de hóspedes não pode exceder a capacidade da suíte.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
    
            decimal valor = DiasReservados * Suite.ValorDiaria;
            decimal divisao = 0.1M;
            decimal valorComDesconto = valor - (divisao * valor);
            

            if (DiasReservados >= 10)
            {
               return valorComDesconto;
            } 
            else 
            {
                 return valor;
            }

        }
    }
}