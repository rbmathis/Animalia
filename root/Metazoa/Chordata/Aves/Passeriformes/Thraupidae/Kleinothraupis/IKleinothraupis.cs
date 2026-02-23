namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Kleinothraupis;

/// <summary>
/// Interface defining characteristics of Kleinothraupis (genus).
/// </summary>
public interface IKleinothraupis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
