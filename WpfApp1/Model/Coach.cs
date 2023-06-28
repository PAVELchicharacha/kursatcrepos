namespace WpfApp1.Model
{
    internal class Coach : IPerson//тренер
    {
        public string CoachName { get; }
        public string CoachsecondName { get; }
        public byte CoachAge { get; }
        public Services Service { get; }

        public Coach(string Name, byte Age, Services Service)
        {
            this.CoachName = Name;
            this.CoachAge = Age;
            this.Service = Service;
        }
    }
}
