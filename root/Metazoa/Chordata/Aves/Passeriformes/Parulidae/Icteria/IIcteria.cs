namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Icteria;

/// <summary>
/// Interface defining characteristics of Icteria (genus).
/// </summary>
public interface IIcteria
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
