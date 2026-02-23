namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae.Setirostris;

/// <summary>
/// Interface defining characteristics of Setirostris (genus).
/// </summary>
public interface ISetirostris
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
