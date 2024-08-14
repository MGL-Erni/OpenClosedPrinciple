namespace OpenClosedPrinciple
{
    /// <summary>
    /// This -Context class unites the different IEncryption implementations once more.
    /// It uses the STRATEGY PATTERN!
    /// It makes it so that other code does not become too dependent on a specific
    /// implementation of Encryption.
    /// </summary>
    internal class EncryptionContext
    {
        // this holds the encryption strategy being used
        private readonly IEncryption _encryption;

        // the constructor takes an ACTUAL IMPLEMENTATION of IEncryption
        // e.g. AES, RSA
        public EncryptionContext(IEncryption encryption)
        {
            // now the encryption method is abstracted into a variable
            _encryption = encryption;
        }

        public string Encrypt(string data)
        {
            // and we use the variable instead of the real method
            // following the theme of ABSTRACTION in order to 
            // acommodate many possible implementations!
            return _encryption.Encrypt(data);
        }
    }


}
