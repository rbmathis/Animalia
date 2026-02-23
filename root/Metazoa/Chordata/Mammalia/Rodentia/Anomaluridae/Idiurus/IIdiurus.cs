namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Anomaluridae.Idiurus;

/// <summary>
/// Interface defining characteristics of Idiurus (genus).
/// </summary>
public interface IIdiurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
