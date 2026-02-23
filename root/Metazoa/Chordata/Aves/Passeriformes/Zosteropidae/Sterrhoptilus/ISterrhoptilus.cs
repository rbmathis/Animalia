namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Zosteropidae.Sterrhoptilus;

/// <summary>
/// Interface defining characteristics of Sterrhoptilus (genus).
/// </summary>
public interface ISterrhoptilus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
