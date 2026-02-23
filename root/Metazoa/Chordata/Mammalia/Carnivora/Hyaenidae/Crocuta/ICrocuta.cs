namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Hyaenidae.Crocuta;

/// <summary>
/// Interface defining characteristics of Crocuta (genus).
/// </summary>
public interface ICrocuta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
