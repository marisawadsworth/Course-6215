namespace Exercise02
{
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }

        public Student(int i, string f, string l)
        {
            Id = i;
            FName = f;
            LName = l;
        }

        public string Email()
        {
           return $"{Id}@student.springfield.edu";
        }
    }
}