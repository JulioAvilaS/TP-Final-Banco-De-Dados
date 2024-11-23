namespace AplicationTpDB.Models
{
    public class ConsultaModel
    {
        public int ID { get; set; }
        public int MedicoCRM { get; set; }
        public int TitularCodIdentificacao { get; set; }
        public int ProcedimentoID { get; set; }
        public string CPFPaciente { get; set; }
        public string UnidadeMedicaCNPJ { get; set; }
        public string Sala { get; set; }
        public string Andar { get; set; }
        public string Bloco { get; set; }
        public string Predio { get; set; }
        public int TempoEstimado { get; set; }
        public string Status { get; set; }
        public float Valor { get; set; }
        public string Descricao { get; set; }
        public DateTime Agendamento { get; set; }
    }
}
