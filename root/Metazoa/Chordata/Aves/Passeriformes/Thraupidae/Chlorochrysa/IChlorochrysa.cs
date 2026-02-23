namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Chlorochrysa;

/// <summary>
/// Interface defining characteristics of Chlorochrysa (genus).
/// </summary>
public interface IChlorochrysa
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
