public abstract class Employee {
    public int Id { get; set; }
    public string Name { get; set; }
    public double BaseSalary { get; set; }

    public abstract double CalculateSalary();
}
