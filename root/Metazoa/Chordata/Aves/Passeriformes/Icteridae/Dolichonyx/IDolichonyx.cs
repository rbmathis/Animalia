namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Dolichonyx;

/// <summary>
/// Interface defining characteristics of Dolichonyx (genus).
/// </summary>
public interface IDolichonyx
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
