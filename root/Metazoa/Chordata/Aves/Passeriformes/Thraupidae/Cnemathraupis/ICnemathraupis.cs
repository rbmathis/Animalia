namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Cnemathraupis;

/// <summary>
/// Interface defining characteristics of Cnemathraupis (genus).
/// </summary>
public interface ICnemathraupis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
