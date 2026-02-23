namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Indriidae.Hadropithecus;

/// <summary>
/// Interface defining characteristics of Hadropithecus (genus).
/// </summary>
public interface IHadropithecus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
