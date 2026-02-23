namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhinocryptidae.Melanopareia;

/// <summary>
/// Interface defining characteristics of Melanopareia (genus).
/// </summary>
public interface IMelanopareia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
