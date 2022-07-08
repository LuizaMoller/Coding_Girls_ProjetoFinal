namespace Escola.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public char Sexo { get; set; }
        public int? TotalFaltas { get; set; }

        //Foreing Key
        public int TurmaId { get; set; }

        // Navigation property
        public virtual Turma? Turma { get; }

    }
}
