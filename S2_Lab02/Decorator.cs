namespace S2_Lab02
{
    public abstract class Salary
    {
        public abstract double Cost();
    }

    public class PilotSalary : Salary
    {
        public override double Cost()
        {
            return 3500;
        }
    }
    
    public class StewardessSalary : Salary
    {
        public override double Cost()
        {
            return 1500;
        }
    }

    public abstract class AwardsDecorator : Salary
    {
        protected readonly Salary Salary;
        public AwardsDecorator(Salary salary)
        {
            Salary = salary;
        }
    }

    public class FiveYearsWorkExperience : AwardsDecorator
    {
        public FiveYearsWorkExperience(Salary salary) : base(salary) { }
        
        public override double Cost()
        {
            return 350 + Salary.Cost();
        }
    }

    public class FlightAce : AwardsDecorator
    {
        public FlightAce(Salary salary) : base(salary) { }
        
        public override double Cost()
        {
            return 700 + Salary.Cost();
        }
    }
}