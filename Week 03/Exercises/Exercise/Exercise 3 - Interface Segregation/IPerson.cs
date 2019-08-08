namespace Exercise_3___Interface_Segregation
{
    interface IPerson
    {
        string FName { get; set; }
        string LName { get; set; }
        int Age { get; set; }
        string Job();
    }
}
