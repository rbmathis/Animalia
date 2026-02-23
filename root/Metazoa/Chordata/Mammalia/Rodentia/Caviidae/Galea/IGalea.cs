namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Caviidae.Galea;

/// <summary>
/// Interface defining characteristics of Galea (genus).
/// </summary>
public interface IGalea
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
