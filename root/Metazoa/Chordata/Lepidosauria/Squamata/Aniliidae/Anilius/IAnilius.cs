namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Aniliidae.Anilius;

/// <summary>
/// Interface defining characteristics of Anilius (genus).
/// </summary>
public interface IAnilius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
