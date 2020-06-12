namespace ItemManager.Domain.Entities
{
    public class PedidoEndereco
    {
        public int Id { get; set; }
        public int PedidoId { get; set; }
        public int EnderecoId { get; set; }
    }
}
