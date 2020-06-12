namespace ItemManager.Domain.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        public int EnderecoEntregaId { get; set; }
        public int FormaPagamentoId { get; set; }
        public string DadosPagamento { get; set; }
    }
}
