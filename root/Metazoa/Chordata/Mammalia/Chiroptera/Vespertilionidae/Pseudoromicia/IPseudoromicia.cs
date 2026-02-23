namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Pseudoromicia;

/// <summary>
/// Interface defining characteristics of Pseudoromicia (genus).
/// </summary>
public interface IPseudoromicia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
