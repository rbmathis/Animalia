namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Phoeniculidae.Phoeniculus;

/// <summary>
/// Interface defining characteristics of Phoeniculus (genus).
/// </summary>
public interface IPhoeniculus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
