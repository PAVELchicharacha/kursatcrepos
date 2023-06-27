namespace WpfApp1.Model
{
    internal class Services//услуги
    {
        public string Name { get; }
        public string Description { get; }
        public float Price { get; }
        public Services(string Name, float Price, string Description = "")
        {
            this.Name = Name;
            this.Price = Price;
            this.Description = Description;
        }
    }
}
