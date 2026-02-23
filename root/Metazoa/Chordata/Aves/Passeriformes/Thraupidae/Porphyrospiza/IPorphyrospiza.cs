namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Porphyrospiza;

/// <summary>
/// Interface defining characteristics of Porphyrospiza (genus).
/// </summary>
public interface IPorphyrospiza
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
