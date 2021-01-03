using System;
using ClientServerLib.Model;
using System.Collections.Generic;

namespace ClientServerLib.Repositories
{
    /// <summary>
    /// Class for working with messages.
    /// </summary>
    public class ServerMessageRepository
    {
        /// <summary>
        /// List of client messages
        /// </summary>
        public List<string> Messages { get; set; }

        public ServerMessageRepository()
        {
            Messages = new List<string>();
        }

        /// <summary>
        /// Constructor <see cref="ServerMessageRepository"/>
        /// </summary>
        /// <param name="client"></param>
        public ServerMessageRepository(Client client) : this()
        {
            client.NewMessage += (sender, e) =>
            {
                Console.WriteLine(MakeTransliterationFromRusIntoEnglish(e.Message));
                Messages.Add(MakeTransliterationFromRusIntoEnglish(e.Message));
            };
        }

        /// <summary>
        /// Method for transliteration from Russian into English.
        /// </summary>
        /// <param name="message">Input messege.</param>
        /// <returns> Returns a string after transliteration.</returns>
        public string MakeTransliterationFromRusIntoEnglish(string message)
        {
            string resultMessage = string.Empty;
            string rusPattern = "абвгдеёжзийк" + "лмнопрстуфхцчшщ" + "ьыъэюя" + "АБВГДЕЁЖЗИЙКЛМНО" + "ПРСТУФХЦЧШЩЬЫЪЭЮЯ";
            string[] latPatternArr = {"a", "b", "v", "g", "d", "e", "yo", "zh", "z", "i", "y", "k",
                "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "kh", "ts", "ch", "sh", "shch",
                "'", "y", "'", "e", "yu", "ya",
                "A", "B", "V", "G", "D", "E", "Yo", "Zh", "Z", "I", "Y", "K", "L", "M", "N", "O",
                "P", "R", "S", "T", "U", "F", "Kh", "Ts", "Ch", "Sh", "Shch", "'", "Y", "'", "E", "Yu", "Ya"};
            char messageLetter = default;
            string patternLatLetter = string.Empty;
            bool letterIsEquel = false;

            for (int i = 0; i < message.Length; i++)
            {
                messageLetter = message[i];
                letterIsEquel = false;

                for (int j = 0; j < rusPattern.Length; j++)
                {
                    if (messageLetter == rusPattern[j])
                    {
                        letterIsEquel = true;
                        patternLatLetter = latPatternArr[j];
                        break;
                    }
                }
                if (letterIsEquel)
                    resultMessage += patternLatLetter;
                else
                    resultMessage += messageLetter;
            }
            return resultMessage;
        }

        /// <summary>
        /// Comparing one message with another.
        /// </summary>
        /// <param name="obj">The compared rectangle.</param>
        /// <returns>True if equal. False if not equal.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            ServerMessageRepository r = (ServerMessageRepository)obj;
            return Messages.SequenceEqual(r.Messages);
        }

        /// <summary>
        /// Calculate hash code.
        /// </summary>
        /// <returns>The total hesh code.</returns>
        public override int GetHashCode()
        {
            return Messages.GetHashCode();
        }
    }
}
