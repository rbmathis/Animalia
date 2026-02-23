namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Xiphidiopicus;

/// <summary>
/// Interface defining characteristics of Xiphidiopicus (genus).
/// </summary>
public interface IXiphidiopicus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
