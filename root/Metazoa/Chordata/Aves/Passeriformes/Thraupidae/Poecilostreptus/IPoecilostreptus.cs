namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Poecilostreptus;

/// <summary>
/// Interface defining characteristics of Poecilostreptus (genus).
/// </summary>
public interface IPoecilostreptus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
