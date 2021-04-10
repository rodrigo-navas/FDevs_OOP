namespace FDevs_Console_ClassLibrary.Pilares_OOP
{
    public class Cafeteira : Eletrodomestico
    {
        public Cafeteira(string nome, int voltagem) : base(nome, voltagem)
        {

        }

        public Cafeteira() : base("Padrao", 220)
        {

        }

        private void AquecerAgua() { }
        private void MoerGraos() { }

        public void PrepararCafe()
        {
            Testar();
            AquecerAgua();
            MoerGraos();
        }

        public override void Desligar()
        {
            // Implementacao Ligar
        }

        public override void Ligar()
        {
            // Implementacao Ligar
        }

        public override void Testar()
        {
            //
        }
    }
}
