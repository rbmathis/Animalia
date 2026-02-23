namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Leiopicus;

/// <summary>
/// Interface defining characteristics of Leiopicus (genus).
/// </summary>
public interface ILeiopicus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
