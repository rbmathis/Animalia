namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Nesoctites;

/// <summary>
/// Interface defining characteristics of Nesoctites (genus).
/// </summary>
public interface INesoctites
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
