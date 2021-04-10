namespace FDevs_Console_ClassLibrary.Pilares_OOP
{
    public class ProducaoCafe
    {
        public ProducaoCafe()
        {
            var cafe = new Cafeteira();
            cafe.Ligar();
            cafe.PrepararCafe();
            cafe.Desligar();
        }
    }
}
