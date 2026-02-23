namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Litopterna.Macraucheniidae.Macrauchenia;

/// <summary>
/// Interface defining characteristics of Macrauchenia (genus).
/// </summary>
public interface IMacrauchenia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
