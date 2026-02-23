namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Cheloniidae.Natator;

/// <summary>
/// Interface defining characteristics of Natator (genus).
/// </summary>
public interface INatator
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
