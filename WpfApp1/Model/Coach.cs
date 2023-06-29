namespace WpfApp1.Model
{
    internal class Coach : Person//тренер
    {
        public Services Service { get; }

        public Coach(string name, string secondName, byte age, Sex sex, Services services) 
            : base(name, secondName, age, sex)
        {
            Service = services;
        }
    }
}
