using System;

namespace _09_Portfolio
{
    public class SavingsAccount : IAsset
    {
        public SavingsAccount(string v1, double v2, double v3)
        {
            InterestRate = v3;
            Name = v1;
            Value = v2;
        }
        
        
        public double Value { get; set; }
        public double InterestRate { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return "SavingsAccount[value=" + string.Format("{0:0.0}",Value).ToString().Replace(',', '.') + ",interestRate=" + InterestRate.ToString().Replace(',', '.') + "]";
        }

        public void ApplyInterest()
        {
            throw new NotImplementedException();
        }

        public double GetValue()
        {
            return Value;
        }
    }
}