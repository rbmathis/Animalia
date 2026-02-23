namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Palaeopropithecidae.Palaeopropithecus;

/// <summary>
/// Interface defining characteristics of Palaeopropithecus (genus).
/// </summary>
public interface IPalaeopropithecus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
