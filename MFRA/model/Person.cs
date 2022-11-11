namespace MFRA.model
{
    public class Person
    {
        public Person():this("dummy","")
        {
        }

        public Person(string navn, string tlf)
        {
            Navn = navn;
            Tlf = tlf;
        }

        public String Navn { get; set; }
        public String Tlf { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(Navn)}={Navn}, {nameof(Tlf)}={Tlf}}}";
        }
    }
}
