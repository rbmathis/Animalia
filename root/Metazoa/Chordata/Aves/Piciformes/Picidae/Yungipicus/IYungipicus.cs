namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Yungipicus;

/// <summary>
/// Interface defining characteristics of Yungipicus (genus).
/// </summary>
public interface IYungipicus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
