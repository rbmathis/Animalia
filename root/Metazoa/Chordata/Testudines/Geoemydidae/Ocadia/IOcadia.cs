namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Ocadia;

/// <summary>
/// Interface defining characteristics of Ocadia (genus).
/// </summary>
public interface IOcadia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
