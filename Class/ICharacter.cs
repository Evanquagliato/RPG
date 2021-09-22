namespace RPG.Class
{
    public interface ICharacterBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
    }



    public interface ICharacterCombat
    {
        public int Attack { get; set; }
        public int Defense { get; set; }
    }
}