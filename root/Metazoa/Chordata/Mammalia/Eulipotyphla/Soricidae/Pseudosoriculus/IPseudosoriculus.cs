namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Pseudosoriculus;

/// <summary>
/// Interface defining characteristics of Pseudosoriculus (genus).
/// </summary>
public interface IPseudosoriculus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
