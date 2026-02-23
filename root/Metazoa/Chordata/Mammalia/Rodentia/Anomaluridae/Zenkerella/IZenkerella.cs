namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Anomaluridae.Zenkerella;

/// <summary>
/// Interface defining characteristics of Zenkerella (genus).
/// </summary>
public interface IZenkerella
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
