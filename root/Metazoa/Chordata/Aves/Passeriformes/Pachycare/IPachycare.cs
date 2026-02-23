namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pachycare;

/// <summary>
/// Interface defining characteristics of Pachycare (genus).
/// </summary>
public interface IPachycare
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
