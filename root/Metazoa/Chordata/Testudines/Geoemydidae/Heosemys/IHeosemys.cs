namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Heosemys;

/// <summary>
/// Interface defining characteristics of Heosemys (genus).
/// </summary>
public interface IHeosemys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
