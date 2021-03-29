namespace S2_Lab02
{
    #region Model

    public abstract class Model
    {
        public string Name { get; protected set; }
    }

    public class CargoModel : Model
    {
        public CargoModel()
        {
            Name = "Пт-819";
        }
    }
    
    public class PassengerModel : Model
    {
        public PassengerModel()
        {
            Name = "Р-210";
        }
    }
    
    public class WarModel : Model
    {
        public WarModel()
        {
            Name = "Су-125";
        }
    }

    #endregion

    #region Type
    
    public abstract class Type
    {
        public string Name { get; protected set; }
    }

    public class CargoType : Type
    {
        public CargoType()
        {
            Name = "Грузовой";
        }
    }
    
    public class PassengerType : Type
    {
        public PassengerType()
        {
            Name = "Пассажирский";
        }
    }
    
    public class WarType : Type
    {
        public WarType()
        {
            Name = "Военный";
        }
    }
    
    #endregion

    #region Factory

    public interface IPlaneFactory
    {
        Type CreateType();
        Model CreateModel();
    }

    public class CargoPlaneFactory : IPlaneFactory
    {
        public Type CreateType()
        {
            return new CargoType();
        }

        public Model CreateModel()
        {
            return new CargoModel();
        }
    }
    
    public class PassengerPlaneFactory : IPlaneFactory
    {
        public Type CreateType()
        {
            return new PassengerType();
        }
        
        public Model CreateModel()
        {
            return new PassengerModel();
        }
    }
    
    public class WarPlaneFactory : IPlaneFactory
    {
        public Type CreateType()
        {
            return new WarType();
        }
        
        public Model CreateModel()
        {
            return new WarModel();
        }
    }

    #endregion
}