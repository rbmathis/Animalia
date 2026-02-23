namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Eurylaimidae.Pseudocalyptomena;

/// <summary>
/// Interface defining characteristics of Pseudocalyptomena (genus).
/// </summary>
public interface IPseudocalyptomena
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
