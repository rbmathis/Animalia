namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Leuconotopicus;

/// <summary>
/// Interface defining characteristics of Leuconotopicus (genus).
/// </summary>
public interface ILeuconotopicus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
