namespace Exercise02
{
    interface IPerson
    {
        int Id { get; set; }
        string FName { get; set; }
        string LName { get; set; }

        string Email();
    }
}