namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Pseudocolaptes;

/// <summary>
/// Interface defining characteristics of Pseudocolaptes (genus).
/// </summary>
public interface IPseudocolaptes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
