using System;

namespace MarkSeemann.LegacyCodeKata
{
    class Cypher : ICypher
    {
        public string Encrypt(string message)
        {
            char[] array = message.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
