namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Triacanthidae.Pseudotriacanthus;

/// <summary>
/// Interface defining characteristics of Pseudotriacanthus (genus).
/// </summary>
public interface IPseudotriacanthus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
