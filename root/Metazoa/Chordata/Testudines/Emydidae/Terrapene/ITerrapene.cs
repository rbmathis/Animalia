namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Terrapene;

/// <summary>
/// Interface defining characteristics of Terrapene (genus).
/// </summary>
public interface ITerrapene
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
