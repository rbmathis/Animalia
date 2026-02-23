namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cirrhitidae.Cirrhitus;

/// <summary>
/// Interface defining characteristics of Cirrhitus (genus).
/// </summary>
public interface ICirrhitus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
