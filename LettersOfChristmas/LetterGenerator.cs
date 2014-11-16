using System;
using System.Collections.Generic;
using System.Linq;

namespace LettersOfChristmas
{
    public class LetterGenerator
    {
        public List<EmailWithLetters> GetLettersFromEmailsAndCount(IEnumerable<string> emails, int numberOfLettersPerEmail)
        {
            if (emails == null)
                throw new ArgumentNullException("emails");

            int numberOfEmails = emails.Count();
            List<EmailWithLetters> results = new List<EmailWithLetters>(numberOfEmails);

            var alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            Shuffle(alpha);
            int counter = 0;
            foreach (var email in emails)
            {
                EmailWithLetters emailWithLetters = new EmailWithLetters(email);
                for (int i = 0; i < numberOfLettersPerEmail; i++)
                    emailWithLetters.AddLetter(alpha[counter++]);

                results.Add(emailWithLetters);
            }

            return results;
        }

        /// <summary>
        /// Used in Shuffle(T).
        /// </summary>
        static readonly Random Random = new Random();

        /// <summary>
        /// Shuffle the array.
        /// </summary>
        /// <typeparam name="T">Array element type.</typeparam>
        /// <param name="array">Array to shuffle.</param>
        public static void Shuffle<T>(T[] array)
        {
            var random = Random;
            for (int i = array.Length; i > 1; i--)
            {
                // Pick random element to swap.
                int j = random.Next(i); // 0 <= j <= i-1
                // Swap.
                T tmp = array[j];
                array[j] = array[i - 1];
                array[i - 1] = tmp;
            }
        }
    }
}
