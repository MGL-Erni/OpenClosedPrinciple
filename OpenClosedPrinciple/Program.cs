namespace OpenClosedPrinciple
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // using AES Encryption
            IEncryption aesEncryption = new AESEncryption();
            EncryptionContext aesContext = new EncryptionContext(aesEncryption);
            Console.WriteLine(aesContext.Encrypt("some data"));

            // using RSA Encryption
            IEncryption rsaEncryption = new RSAEncryption();
            EncryptionContext rsaContext = new EncryptionContext(rsaEncryption);
            Console.WriteLine(rsaContext.Encrypt("some data"));
        }
    }
}
