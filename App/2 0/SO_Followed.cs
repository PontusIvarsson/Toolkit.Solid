using App._2_0;

namespace App._2_0_Followed
{

    class SO_Followed
    {
        private Output output;

        public SO_Followed(Output output)
        {
            this.output = output;
        }

        public void ShowMePrinciple(SOLID_Princaple[] principles)
        {
            foreach (var principle in principles)
            {
                output.WriteLine(principle.Name);
                output.WriteLine(principle.Description);
            }
        }
    }

    public interface SOLID_Princaple
    {
        string Name { get; }
        string Description { get; }
    }

    public class SRP : SOLID_Princaple
    {
        string SOLID_Princaple.Name => "Single Responsibility Principle(SRP)";
        string SOLID_Princaple.Description => string.Format("SRP says: {0}", "Every software module should have only one reason to change");
    }

    public class OC : SOLID_Princaple
    {
        string SOLID_Princaple.Name => "Open/Closed Principle";
        string SOLID_Princaple.Description => string.Format("The Open/closed Principle says: {0}", "A software module /class is open for extension and closed for modification");
    }
}
