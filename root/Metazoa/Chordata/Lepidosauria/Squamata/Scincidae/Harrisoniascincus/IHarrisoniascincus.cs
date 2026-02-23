namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Harrisoniascincus;

/// <summary>
/// Interface defining characteristics of Harrisoniascincus (genus).
/// </summary>
public interface IHarrisoniascincus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
