namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Artamidae.Strepera;

/// <summary>
/// Interface defining characteristics of Strepera (genus).
/// </summary>
public interface IStrepera
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
