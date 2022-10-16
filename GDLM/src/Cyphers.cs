namespace GDLM
{
    public class Cyphers
    {
        /// <summary>
        /// Xor Cyphers the given data with the given key
        /// </summary>
        /// <param name="key">The key to cypher with</param>
        /// <param name="data">The data to cypher</param>
        /// <returns>The cyphered data</returns>
        public static string XorCypher(string key, string data)
        {
            int dataLen = data.Length;
            int keyLen = key.Length;
            char[] output = new char[dataLen];

            for (int i = 0; i < dataLen; ++i)
            {
                output[i] = (char)(data[i] ^ key[i % keyLen]);
            }

            return new string(output);
        }
    }
}

