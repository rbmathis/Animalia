namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Rhyneptesicus;

/// <summary>
/// Interface defining characteristics of Rhyneptesicus (genus).
/// </summary>
public interface IRhyneptesicus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
