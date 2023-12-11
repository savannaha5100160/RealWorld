namespace Assignment3RealWorld
{
     class Program
    {
        static void Main( )
        {
            Person Oliver = new Person ("Oliver", "James", 35, "Strand", "Software Developer", "coding and reading");
            Oliver.Introduce();

            Person Madison = new Person("Madison", "West", 29, "Mossel Bay", "Teacher", "Rugby and cooking");
            Madison.Introduce();

            Person Scott = new Person("Scott", "Evans", 40, "George", "Doctor", "Writing and Mountain biking");
            Scott.Introduce();

            Person Rose = new Person("Rose", "Rivera", 25, "Strand", "Nurse", "Singing and crochet");
            Rose.Introduce();

            Person Ashley = new Person("Ashley", "Rivera", 27, "Strand", "Teacher", "Soccer and painting");
            Ashley.Introduce();

            Person Hunter = new Person("Hunter", "Murray", 30, "Worcester", "Graphic Designer", "Learning and drawing");
            Hunter.Introduce();
        }
    }
}
