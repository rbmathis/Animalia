namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Synanceiidae.Pseudosynanceia;

/// <summary>
/// Interface defining characteristics of Pseudosynanceia (genus).
/// </summary>
public interface IPseudosynanceia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
