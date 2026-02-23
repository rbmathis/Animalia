namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Dives;

/// <summary>
/// Interface defining characteristics of Dives (genus).
/// </summary>
public interface IDives
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
