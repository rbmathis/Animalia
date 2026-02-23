namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Orectolobiformes.Ginglymostomatidae.Pseudoginglymostoma;

/// <summary>
/// Interface defining characteristics of Pseudoginglymostoma (genus).
/// </summary>
public interface IPseudoginglymostoma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
