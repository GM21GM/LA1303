namespace CreatePersonAPI.Models
{
    public class Person
    {
        public int id { get; set; }

        public required string Firstname { get; set; }
        public required string Lastname { get; set; }
        public string Beruf { get; set; }
        public DateOnly Geburtsdatum { get; set; }

    }
}
