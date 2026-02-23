namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Orlitia;

/// <summary>
/// Interface defining characteristics of Orlitia (genus).
/// </summary>
public interface IOrlitia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
