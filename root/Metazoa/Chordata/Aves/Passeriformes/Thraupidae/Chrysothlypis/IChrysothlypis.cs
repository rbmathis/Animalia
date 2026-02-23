namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Chrysothlypis;

/// <summary>
/// Interface defining characteristics of Chrysothlypis (genus).
/// </summary>
public interface IChrysothlypis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
