namespace WpfApp1.Model
{
    internal class Coach : IPerson//тренер
    {
        public string Name { get; }
        public string SecondName { get; }
        public byte Age { get; }
        public Services Service { get; }
        public Sex Sex { get; }

        public Coach(string Name, byte Age, Services Service)
        {
            this.Name = Name;
            this.Age = Age;
            this.Service = Service;
        }
    }
}
