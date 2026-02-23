namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Colaptes;

/// <summary>
/// Interface defining characteristics of Colaptes (genus).
/// </summary>
public interface IColaptes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
