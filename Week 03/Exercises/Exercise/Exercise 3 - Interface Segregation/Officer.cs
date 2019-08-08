namespace Exercise_3___Interface_Segregation
{
    class Officer : IPerson
    {
        public string FName { get; set; }
        public string LName { get; set; }

        public int Age { get; set; }

        public Officer(string f, string l, int a)
        {
            FName = f;
            LName = l;
            Age = a;
        }
        public string Job()
        {
            return "Issue Tickets";
        }
    }
}
