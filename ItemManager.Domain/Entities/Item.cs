namespace ItemManager.Domain.Entities
{
    public class Item
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal ValorUnidade { get; set; }
        public decimal PercentualDesconto { get; set; }
        public byte[] Imagem { get; set; }
        public bool Ativo { get; set; }
    }
}
