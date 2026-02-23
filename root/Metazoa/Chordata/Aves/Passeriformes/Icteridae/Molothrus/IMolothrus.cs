namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Molothrus;

/// <summary>
/// Interface defining characteristics of Molothrus (genus).
/// </summary>
public interface IMolothrus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
