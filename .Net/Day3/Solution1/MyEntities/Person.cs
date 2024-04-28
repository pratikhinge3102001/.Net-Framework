namespace MyEntities
{
    public class Person
    {
        //Private data member
        private int id;

        //Get and set accessor 
        //read and Write
        public int Id { 
            get { return id;}
            set { id = value; }
        }
        //Auto Implemented property
        public string Name { get; set; }

        private int adhar;

        //Read only
        public int AdharNo
        {
            get { return adhar; }
           
        }

        private int age;

        //Write only
        public int Age
        {
           set { age = value; }
        }

        //With Default value
        public float Salary { get; set; }=10000.00f; 

        //Read only 
        public string Address {  get;  }

        //You can not create write only with Auto implemented
        //public string city {   set; }//

    }
}
