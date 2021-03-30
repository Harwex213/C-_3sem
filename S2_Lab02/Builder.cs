namespace S2_Lab02
{
    public abstract class Builder
    {
        protected CrewMember _crewMember;

        public abstract void BuildFirstName(string firstName);
        public abstract void BuildLastName(string lastName);
        public abstract void BuildPatronymic(string patronymic);
        public abstract void BuildAge(int age);
        public abstract void BuildWorkExperience(int year);
        public abstract void BuildPosition(string position);
    }

    public class CrewMemberBuilder : Builder
    {
        public CrewMemberBuilder()
        {
            Reset();
        }
        
        public void Reset()
        {
            _crewMember = new CrewMember();
        }
        
        public override void BuildFirstName(string firstName)
        {
            _crewMember.FirstName = firstName;
        }

        public override void BuildLastName(string lastName)
        {
            _crewMember.LastName = lastName;
        }

        public override void BuildPatronymic(string patronymic)
        {
            _crewMember.Patronymic = patronymic;
        }

        public override void BuildAge(int age)
        {
            _crewMember.Age = age;
        }

        public override void BuildWorkExperience(int workExperience)
        {
            _crewMember.WorkExperience = workExperience;
        }

        public override void BuildPosition(string position)
        {
            _crewMember.Position = position;
        }

        public CrewMember GetProduct()
        {
            var result = _crewMember;
            Reset();
            return result;
        }
    }
}