namespace FDevs_Console_ClassLibrary.Pilares_OOP
{
    public abstract class Eletrodomestico
    {
        private readonly string _nome;
        private readonly int _voltagem;

        public Eletrodomestico(string nome, int voltagem)
        {
            _nome = nome;
            _voltagem = voltagem;
        }

        public abstract void Ligar();
        public abstract void Desligar();
        public virtual void Testar()
        {

        }
    }
}
