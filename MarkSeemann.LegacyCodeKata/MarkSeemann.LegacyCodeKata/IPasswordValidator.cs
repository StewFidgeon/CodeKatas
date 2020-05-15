namespace MarkSeemann.LegacyCodeKata
{
    public interface IPasswordValidator
    {
        public bool Ok(IDataPipe pipe, string password, string confirmation);
    }
}
