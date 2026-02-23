namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Pygmaeascincus;

/// <summary>
/// Interface defining characteristics of Pygmaeascincus (genus).
/// </summary>
public interface IPygmaeascincus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
