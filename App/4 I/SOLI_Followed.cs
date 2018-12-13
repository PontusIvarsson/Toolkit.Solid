using App._1;

namespace App._4_SOLI_Followed
{
    class SOLI_Followed
    {
        private Output output;

        public SOLI_Followed(Output output)
        {
            this.output = output;
        }

        public void ShowPrinciple(object[] principles)
        {
            foreach (var item in principles)
            {
                output.WriteLine(((SOLID_Princaple)item).Name);
                output.WriteLine(((SOLID_Princaple)item).Description);
                if(item is IHaveFormalDefinition)
                    output.WriteLine(((IHaveFormalDefinition)item).FormalDefinition);
                output.WriteLine("________________________________________");
            }
        }
    }

    public class SOLID_Princaple
    {
        public string Name = null;
        public string Description = null;
    }

    public interface IHaveFormalDefinition
    {
        string FormalDefinition { get;  }
    }

    public class SRP : SOLID_Princaple
    {
        public SRP()
        {
            Name = "Single Responsibility Principle(SRP)";
            Description = string.Format("SRP says: {0}", "Every software module should have only one reason to change");
        }
    }

    public class OC : SOLID_Princaple
    {
        public OC()
        {
            Name = "Open/Closed Principle";
            Description = string.Format("The Open/closed Principle says: {0}", "A software module /class is open for extension and closed for modification");
        }
    }

    public class LISKOV : SOLID_Princaple, IHaveFormalDefinition
    {
        public string _formalDefinition = null;

        public LISKOV()
        {
            Name = "Liskov substitution principle";
            _formalDefinition = string.Format("In a computer program, if S is a subtype of T, then objects of type T may be replaced with objects of type S " +
            "(i.e. an object of type T may be substituted with any object of a subtype S)" +
            " without altering any of the desirable properties of the program (correctness, task performed, etc.)");
        }

        string IHaveFormalDefinition.FormalDefinition => _formalDefinition;


    }

}
