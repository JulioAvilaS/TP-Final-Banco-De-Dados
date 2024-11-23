using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;

namespace AplicationTpDB.Models
{
    [Table("pessoa")]
    public class PessoaModel
    {
        [Key]
        [Column("CPF_Pessoa", TypeName = "CHAR(11)")]
        public string CPF {get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Genero { get; set; }

        [Required]
        [Column("Data_Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required]
        public string CEP { get; set; }

        [Required]
        [Column("Numero_Endereco")]
        public int NumeroEndereco { get; set; }

        [Required]
        public string Rua { get; set; }

        [Required]
        public string Bairro { get; set; }

        [JsonIgnore]
        public ICollection<PessoaTelefoneModel> Telefones { get; set; }

        [JsonIgnore]
        public ICollection<PessoaEmailModel> Emails { get; set; }


    }
}
