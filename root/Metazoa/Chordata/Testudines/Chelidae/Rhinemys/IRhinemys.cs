namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Rhinemys;

/// <summary>
/// Interface defining characteristics of Rhinemys (genus).
/// </summary>
public interface IRhinemys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
