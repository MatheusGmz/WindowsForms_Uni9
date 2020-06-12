namespace ItemManager.Domain.Entities
{
    public class PedidoCliente
    {
        public int Id { get; set; }
        public int PedidoId { get; set; }
        public int ClienteId { get; set; }
    }
}
