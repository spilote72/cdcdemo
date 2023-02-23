using System.Security.Cryptography;
using System.Text;

namespace CDCDemo.Helpers;

public static class HashHelper
{
    //
    // https://stackoverflow.com/questions/71444978/sha256-in-c-sharp-not-matching-on-two-objects-with-same-structure-and-data-coul
    //
    public static string GetHash(string payload)
    {
        // Create a SHA256   
        using (SHA256 sha256Hash = SHA256.Create())
        {
            // ComputeHash - returns byte array  
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(payload));

            // Convert byte array to a string formatted as lowercase hex
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }

            return builder.ToString();
        }
    }
}
