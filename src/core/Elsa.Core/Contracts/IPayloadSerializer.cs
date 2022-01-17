namespace Elsa.Contracts;

public interface IPayloadSerializer
{
    T Deserialize<T>(string json) where T : notnull;
    string Serialize<T>(T payload) where T : notnull;
}