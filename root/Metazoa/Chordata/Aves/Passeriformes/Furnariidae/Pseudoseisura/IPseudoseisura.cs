namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Pseudoseisura;

/// <summary>
/// Interface defining characteristics of Pseudoseisura (genus).
/// </summary>
public interface IPseudoseisura
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
