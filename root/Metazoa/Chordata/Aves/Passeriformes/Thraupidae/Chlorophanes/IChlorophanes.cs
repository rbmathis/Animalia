namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Chlorophanes;

/// <summary>
/// Interface defining characteristics of Chlorophanes (genus).
/// </summary>
public interface IChlorophanes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
