namespace AplicationTpDB.Models
{
    public class UnidadeMedicaModel
    {
        public string CNPJ { get; set; }
        public string Nome { get; set; }
        public string CEP { get; set; }
        public int Numero { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }

        public ICollection<UnidadeEmailModel> Emails { get; set; }
        public ICollection<UnidadeTelefoneModel> Telefones { get; set; } 
    }
}
