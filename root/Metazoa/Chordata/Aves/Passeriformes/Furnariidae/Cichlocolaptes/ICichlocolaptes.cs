namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Cichlocolaptes;

/// <summary>
/// Interface defining characteristics of Cichlocolaptes (genus).
/// </summary>
public interface ICichlocolaptes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
