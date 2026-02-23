namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vangidae.Artamella;

/// <summary>
/// Interface defining characteristics of Artamella (genus).
/// </summary>
public interface IArtamella
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
