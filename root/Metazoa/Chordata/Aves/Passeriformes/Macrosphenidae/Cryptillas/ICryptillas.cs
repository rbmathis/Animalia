namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Macrosphenidae.Cryptillas;

/// <summary>
/// Interface defining characteristics of Cryptillas (genus).
/// </summary>
public interface ICryptillas
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
