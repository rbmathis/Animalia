namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Platysternidae.Platysternon;

/// <summary>
/// Interface defining characteristics of Platysternon (genus).
/// </summary>
public interface IPlatysternon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
