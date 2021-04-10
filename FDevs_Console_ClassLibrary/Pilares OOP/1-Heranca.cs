using System;

namespace FDevs_Console_ClassLibrary.Pilares_OOP
{
    public class Pessoa
    {
        public Pessoa(string nome)
        {

        }

        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public int CalcularIdade()
        {
            var dataAtual = DateTime.Now;
            return dataAtual.Year - DataNascimento.Year;
        }
    }

    public class Funcionario : Pessoa
    {
        public Funcionario(string nome) : base(nome)
        {


        }

        public Funcionario() : base("")
        {

        }

        public DateTime DataAdmissao { get; set; }
        public decimal Salario { get; set; }
    }

    public class Heranca
    {
        public Heranca()
        {
            Funcionario func = new Funcionario();
            func.CalcularIdade();
        }
    }
}
