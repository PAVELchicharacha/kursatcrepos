namespace WpfApp1.Model
{
    internal class Coach : IPerson//тренер
    {
// Updated upstream
        public string Name { get; }
<<<<<<< HEAD
  
=======
        public string SecondName { get; }
>>>>>>> 6b5e86a5ca6a772623931c40aec49100c0e6aa5d
        public byte Age { get; }
        public Services Service { get; }

        public Coach(string Name, byte Age, Services Service)
        {
            this.Name = Name;
            this.Age = Age;
            this.Service = Service;
        }
        
//Stashed changes
    }
}
