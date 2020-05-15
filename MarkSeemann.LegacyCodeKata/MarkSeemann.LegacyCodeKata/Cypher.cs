using System;

namespace MarkSeemann.LegacyCodeKata
{
    public class Cypher : ICypher
    {
        public string Encrypt(string message)
        {
            char[] array = message.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
