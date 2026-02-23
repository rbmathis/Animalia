namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Monarchidae.Trochocercus;

/// <summary>
/// Interface defining characteristics of Trochocercus (genus).
/// </summary>
public interface ITrochocercus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
