namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes.Falconidae.Milvago;

/// <summary>
/// Interface defining characteristics of Milvago (genus).
/// </summary>
public interface IMilvago
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
