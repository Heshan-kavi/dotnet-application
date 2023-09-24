namespace Variables
{
    public class Person
    {
        public string FirstName = "";
        public string Secondname = "";
        public int age = 0;
        public string address = "";

        //implemented struct to store the data regarding the age and the address
        public struct PersonalDetails
        {
            public int age;
            public string address;
        }

        public string Introduce()
        {
            PersonalDetails personalDetails = new PersonalDetails();
            personalDetails.age = age;
            personalDetails.address = address;
            Console.WriteLine("Hello there, my name is : " + FirstName + " " + Secondname + " and this is my age : "+ personalDetails.age + " and the address : " + personalDetails.address);
            return FirstName + " " + Secondname;
        }
    }
}

