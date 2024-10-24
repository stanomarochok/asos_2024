namespace DesignPatternsDemo.Structural.Flyweight
{
    internal class CharactersFactory
    {
        private Dictionary<char, ICharacter> _characters = new Dictionary<char, ICharacter>();

        public ICharacter GetCharacter(char character)
        {
            if (!_characters.ContainsKey(character))
            {
                _characters.Add(character, new Character(character));
            }

            return _characters[character];
        }
    }
}
