namespace Variables
{
    public class Person
    {
        public string FirstName = "";
        public string Secondname = "";

        public string Introduce()
        {
            Console.WriteLine("Hello there, my name is : " + FirstName + " " + Secondname);
            return FirstName + " " + Secondname;
        }
    }
}

