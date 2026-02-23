namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae.Sarcops;

/// <summary>
/// Interface defining characteristics of Sarcops (genus).
/// </summary>
public interface ISarcops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
