namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Coryphaspiza;

/// <summary>
/// Interface defining characteristics of Coryphaspiza (genus).
/// </summary>
public interface ICoryphaspiza
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
