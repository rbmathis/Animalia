namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Morenia;

/// <summary>
/// Interface defining characteristics of Morenia (genus).
/// </summary>
public interface IMorenia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
