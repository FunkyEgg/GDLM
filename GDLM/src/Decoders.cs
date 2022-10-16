using System;

namespace GDLM
{
    public class Decoders
    {
        public static string Base64Decode(string data)
        {
            if(string.IsNullOrEmpty(data))
                return string.Empty;
            byte[] bytes = System.Convert.FromBase64String(data);
            return System.Text.Encoding.UTF8.GetString(bytes);
        }
        
        public static string DecodeGdLevelData(string CClevelData)
        {
            string xorKey = "11";
            string data;

            // The steps to decode the level data
            data = GDLM.Cyphers.XorCypher(xorKey, CClevelData);
            data = GDLM.Decoders.Base64Decode(data);
            // g unzip
            
            // once we find level we do that all over again for the level (dont know if we cypher it)

            return data;
        }
    }
}

