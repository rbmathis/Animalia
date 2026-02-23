namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Artamidae.Cracticus;

/// <summary>
/// Interface defining characteristics of Cracticus (genus).
/// </summary>
public interface ICracticus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
