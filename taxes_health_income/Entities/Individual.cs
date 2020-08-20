namespace taxes_health_income.Entities

{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualincome, double healthexpenditures) : base(name, anualincome)
        {
            HealthExpenditures = healthexpenditures;
        }

        public override double Tax()
        {
            if (AnualIncome < 20000.0)
            {
                return (AnualIncome * 0.15) - (HealthExpenditures * 0.5);
            }

            else
            {
                return (AnualIncome * 0.25) - (HealthExpenditures * 0.5);
            }
        }
    }
}