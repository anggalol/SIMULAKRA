namespace SSELib
{
    internal interface IGenericSerialization
    {
        void Serialize(object obj);

        object Deserialize();
    }
}
