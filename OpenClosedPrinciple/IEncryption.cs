namespace OpenClosedPrinciple
{
    /// <summary>
    /// Defines an interface for encryption.
    /// Many kinds of encryption can implement this interface. e.g. AES, RSA, etc.
    /// All of these kinds of encryption must EACH have their OWN CLASS,
    /// rather than all being lumped into a single `Encryption` class.
    /// This INTERFACE is what will ensure that all of those classes
    /// can be used in the same basic ways.
    /// </summary>
    internal interface IEncryption
    {
        string Encrypt(string data);
    }
}
