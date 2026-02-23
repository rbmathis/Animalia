namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Eurylaimidae.Eurylaimus;

/// <summary>
/// Interface defining characteristics of Eurylaimus (genus).
/// </summary>
public interface IEurylaimus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
