namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Pseudoleistes;

/// <summary>
/// Interface defining characteristics of Pseudoleistes (genus).
/// </summary>
public interface IPseudoleistes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
