namespace WpfApp1.Model
{
    enum PaymentType
    {
        Dayly,
        Monthly,
        Yearly,
        ByHour,
        OnePayTime
    }
    internal class ClubServices//услуги
    {
        public string Name { get; }
        public string Description { get; }
        public float Price { get; }
        public PaymentType PaymentType { get; }

        public ClubServices() 
        {
            Name = string.Empty;
            Description = string.Empty;
            Price = 0;
            PaymentType = PaymentType.Dayly;
        }

        public ClubServices(string Name, float Price, PaymentType PaymentType, string Description = "")
        {
            this.Name = Name;
            this.Price = Price;
            this.Description = Description;
            this.PaymentType = PaymentType;
        }

        public override string ToString()
        {
            return $"Услуга {Name} имеет стоимость {Price}, оплата {GetPaymantInfo()}.";
        }

        private string GetPaymantInfo()
        {
            string returnInfo = "";
            switch (PaymentType)
            {
                case PaymentType.Dayly:
                    returnInfo = "подневная";
                    break;
                case PaymentType.Monthly:
                    returnInfo = "ежемесечная";
                    break;
                case PaymentType.ByHour:
                    returnInfo = "почасовая";
                    break;
                case PaymentType.OnePayTime:
                    returnInfo = "Единоразовая";
                    break;

            }
            return returnInfo;
        }
    }
}
