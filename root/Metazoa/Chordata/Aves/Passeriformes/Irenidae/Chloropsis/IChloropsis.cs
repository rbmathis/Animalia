namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Irenidae.Chloropsis;

/// <summary>
/// Interface defining characteristics of Chloropsis (genus).
/// </summary>
public interface IChloropsis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
