namespace TGRS_CSharp_API
{
    public class Game
    {
        public int id;
        public string name;
        public string description;
        public string linkToPic;

        public Game(int Id, string Name, string Description, string LinkToPic)
        {
            id = Id;
            name = Name;
            description = Description;
            linkToPic = LinkToPic;
        }
    }
}
