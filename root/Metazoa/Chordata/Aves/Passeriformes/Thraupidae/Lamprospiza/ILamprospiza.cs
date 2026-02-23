namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Lamprospiza;

/// <summary>
/// Interface defining characteristics of Lamprospiza (genus).
/// </summary>
public interface ILamprospiza
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
