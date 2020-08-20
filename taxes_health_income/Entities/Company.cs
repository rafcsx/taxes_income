namespace taxes_health_income.Entities

{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualincome, int numberofemployees)
            : base(name, anualincome)
        {
            NumberOfEmployees = numberofemployees;
        }

        public override double Tax()
        {
            if (NumberOfEmployees > 10.0)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }

    }
}