namespace S2_Lab02
{
    public abstract class Builder
    {
        protected CrewMember _crewMember;

        public abstract void BuildPartName();
        public abstract void BuildPartAbout();
        public abstract void BuildPartWork();
    }

    public class PilotBuilder : Builder
    {
        public PilotBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _crewMember = new CrewMember();
        }
        
        public override void BuildPartName()
        {
            _crewMember.FirstName = "Oleg";
            _crewMember.LastName = "Kaportsev";
            _crewMember.Patronymic = "Andreevich";
        }

        public override void BuildPartAbout()
        {
            _crewMember.Age = 19;
        }

        public override void BuildPartWork()
        {
            _crewMember.WorkExperience = 5;
            _crewMember.Position = "Пилот";
        }
    }
}