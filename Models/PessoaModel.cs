using System.Globalization;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;

namespace AplicationTpDB.Models
{
    public class PessoaModel
    {
        public string CPF {get; set; }
        public string Nome { get; set; }
        public string Genero { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CEP { get; set; }
        public int NumeroEndereco { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }

        [JsonIgnore]
        public ICollection<PessoaTelefoneModel> Telefones { get; set; }

        [JsonIgnore]
        public ICollection<PessoaEmailModel> Emails { get; set; }


    }
}
