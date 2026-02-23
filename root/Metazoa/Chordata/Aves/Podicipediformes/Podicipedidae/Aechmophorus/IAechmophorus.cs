namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Podicipediformes.Podicipedidae.Aechmophorus;

/// <summary>
/// Interface defining characteristics of Aechmophorus (genus).
/// </summary>
public interface IAechmophorus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
