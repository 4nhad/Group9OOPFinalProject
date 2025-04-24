public class FullTimeEmployee : Employee, ISalaryCalculator {
    public double BonusRate { get; set; }

    public override double CalculateSalary() {
        return BaseSalary + CalculateBonus();
    }

    public double CalculateBonus() {
        return BaseSalary * BonusRate;
    }
}
