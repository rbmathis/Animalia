namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Pseudobufo;

/// <summary>
/// Interface defining characteristics of Pseudobufo (genus).
/// </summary>
public interface IPseudobufo
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
