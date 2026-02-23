namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Chrysocolaptes;

/// <summary>
/// Interface defining characteristics of Chrysocolaptes (genus).
/// </summary>
public interface IChrysocolaptes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
