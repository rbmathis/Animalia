namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Eurypygiformes.Rhynochetidae.Rhynochetos;

/// <summary>
/// Interface defining characteristics of Rhynochetos (genus).
/// </summary>
public interface IRhynochetos
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
