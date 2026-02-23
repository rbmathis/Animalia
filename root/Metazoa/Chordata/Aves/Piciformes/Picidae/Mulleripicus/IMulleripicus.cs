namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Mulleripicus;

/// <summary>
/// Interface defining characteristics of Mulleripicus (genus).
/// </summary>
public interface IMulleripicus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
