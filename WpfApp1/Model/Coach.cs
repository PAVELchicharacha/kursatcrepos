namespace WpfApp1.Model
{
    internal class Coach : Person//тренер
    {
        public ClubServices Service { get; }

        public Coach(string name, string secondName, byte age, Sex sex, ClubServices services) 
            : base(name, secondName, age, sex)
        {
            Service = services;
        }
    }
}
