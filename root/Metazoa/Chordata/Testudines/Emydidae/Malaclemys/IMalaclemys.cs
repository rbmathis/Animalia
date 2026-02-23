namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Malaclemys;

/// <summary>
/// Interface defining characteristics of Malaclemys (genus).
/// </summary>
public interface IMalaclemys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
