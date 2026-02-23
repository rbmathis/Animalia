namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Geocolaptes;

/// <summary>
/// Interface defining characteristics of Geocolaptes (genus).
/// </summary>
public interface IGeocolaptes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
