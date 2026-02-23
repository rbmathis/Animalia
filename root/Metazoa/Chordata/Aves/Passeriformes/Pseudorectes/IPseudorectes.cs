namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pseudorectes;

/// <summary>
/// Interface defining characteristics of Pseudorectes (genus).
/// </summary>
public interface IPseudorectes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
