namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lorisidae.Loris;

/// <summary>
/// Interface defining characteristics of Loris (genus).
/// </summary>
public interface ILoris
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
