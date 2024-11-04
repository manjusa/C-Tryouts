

namespace C_11PdfBookTryOuts.ch5
{
    public class PersonCh5 : object
    {
        //Author's class is much bigger, mine in concsie for this "More about methods"ch05
        //     eg https://github.com/markjprice/cs11dotnet7/blob/main/notebooks/Chapter05.dib

        // fields
        public string Name;
        public DateTime DateOfBirth;
        public List<PersonCh5> Children = new();

        // constants
        public const string Species = "Homo Sapien";

        // read-only fields
        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;

        //of interest properties
        private bool married = false;
        public bool Married => married;

        private PersonCh5? spouse = null;
        public PersonCh5? Spouse => spouse;

        // constructors
        public PersonCh5()
        {
            // set default values for fields
            // including read-only fields
            Name = "Unknown";
            Instantiated = DateTime.Now;
        }

        public PersonCh5(string initialName, string homePlanet)
        {
            Name = initialName;
            HomePlanet = homePlanet;
            Instantiated = DateTime.Now;
        }
      
        // static method to marry
        public static void Marry(PersonCh5 p1, PersonCh5 p2)
        {
            p1.Marry(p2);
        }
        // instance method to marry
        public void Marry(PersonCh5 partner)
        {
            if (married) return;
            spouse = partner;
            married = true;
            partner.Marry(this); // this is the current object
        }
    }
}
