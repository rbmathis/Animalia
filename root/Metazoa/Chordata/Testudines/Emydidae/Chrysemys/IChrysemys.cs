namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Chrysemys;

/// <summary>
/// Interface defining characteristics of Chrysemys (genus).
/// </summary>
public interface IChrysemys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
