namespace AlmoxarifadoBackAPI.DTO
{
    public class ProdutoCadastroDTO
    {
        public string Descricao { get; set; }
        public string UnMdedida { get; set; }
        public bool EPermanente { get; set; }
        public float EstoqueAtual { get; set; }
        public float PrecoProduto { get; set; }
        public int IdCategoria { get; set; }
    }
}
