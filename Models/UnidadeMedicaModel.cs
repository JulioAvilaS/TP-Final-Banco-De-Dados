using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicationTpDB.Models
{
    [Table("unidade_medica")]
    public class UnidadeMedicaModel
    {
        [Key]
        public string CNPJ { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string CEP { get; set; }

        [Required]
        public int Numero { get; set; }

        [Required]
        public string Rua { get; set; }

        [Required]
        public string Bairro { get; set; }

        public ICollection<UnidadeEmailModel> Emails { get; set; }
        public ICollection<UnidadeTelefoneModel> Telefones { get; set; } 
    }
}
