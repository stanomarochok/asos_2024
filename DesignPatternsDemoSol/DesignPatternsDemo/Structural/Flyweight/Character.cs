namespace DesignPatternsDemo.Structural.Flyweight
{
    public class Character : ICharacter
    {
        private readonly char symbol;

        public Character(char symbol)
        {
            this.symbol = symbol;
        }

        public char GetCharacter()
        {
            return symbol;
        }
    }
}
