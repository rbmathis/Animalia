namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Petroicidae.Pachycephalopsis;

/// <summary>
/// Interface defining characteristics of Pachycephalopsis (genus).
/// </summary>
public interface IPachycephalopsis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
