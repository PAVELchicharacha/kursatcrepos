namespace WpfApp1.Model
{
    internal class Coach : IPerson//тренер
    {
        public string Name { get; }
        public byte Age { get; }
        public Services Service { get; }

        public Coach(string Name, byte Age, Services Service)
        {
            this.Name = Name;
            this.Age = Age;
            this.Service = Service;
        }
    }
}
