using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace S2_Lab02
{
    public interface IFlyStrategy
    {
        public string Fly();
    }

    public class FlyByNone : IFlyStrategy
    {
        public string Fly()
        {
            return "We can't fly";
        }
    }
    
    public class FlyByJetPowered : IFlyStrategy
    {
        public string Fly()
        {
            return "We're flying on jet propulsion";
        }
    }
    
    public class FlyByElectricMotor : IFlyStrategy
    {
        public string Fly()
        {
            return "We're flying on electric motor";
        }
    }
}