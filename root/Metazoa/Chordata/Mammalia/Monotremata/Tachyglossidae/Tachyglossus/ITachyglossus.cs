namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Monotremata.Tachyglossidae.Tachyglossus;

/// <summary>
/// Interface defining characteristics of Tachyglossus (genus).
/// </summary>
public interface ITachyglossus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
