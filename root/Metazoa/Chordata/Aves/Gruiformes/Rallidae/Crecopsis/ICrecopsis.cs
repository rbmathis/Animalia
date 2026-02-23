namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Crecopsis;

/// <summary>
/// Interface defining characteristics of Crecopsis (genus).
/// </summary>
public interface ICrecopsis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
