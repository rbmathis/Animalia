namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Haplonycteris;

/// <summary>
/// Interface defining characteristics of Haplonycteris (genus).
/// </summary>
public interface IHaplonycteris
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
