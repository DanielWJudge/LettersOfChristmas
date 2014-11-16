using System.Collections.Generic;

namespace LettersOfChristmas
{
    public class EmailWithLetters
    {
        public string Email { get; private set; }
        public List<char> Letters { get; private set; }

        public EmailWithLetters(string email)
        {
            Email = email;
        }

        public void AddLetter(char letter)
        {
            if (Letters == null)
                Letters = new List<char>(7);

            Letters.Add(letter);
        }
    }
}