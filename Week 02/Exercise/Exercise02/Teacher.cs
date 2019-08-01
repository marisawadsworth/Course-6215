namespace Exercise02
{
    class Teacher : IPerson
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }

        public Teacher(int i, string f, string l)
        {
            Id = i;
            FName = f;
            LName = l;
        }

        public string Email()
        {
            return $"{FName}.{LName}@springfield.edu";
        }
    }
}