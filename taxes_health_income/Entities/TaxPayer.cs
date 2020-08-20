namespace taxes_health_income.Entities

{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public TaxPayer(string name, double anualincome)
        {
            Name = name;
            AnualIncome = anualincome;
        }

        public abstract double Tax();
    }
}