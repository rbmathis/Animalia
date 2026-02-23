namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Reinwardtipicus;

/// <summary>
/// Interface defining characteristics of Reinwardtipicus (genus).
/// </summary>
public interface IReinwardtipicus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
