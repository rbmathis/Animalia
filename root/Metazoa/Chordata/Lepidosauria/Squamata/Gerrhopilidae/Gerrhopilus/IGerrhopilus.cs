namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gerrhopilidae.Gerrhopilus;

/// <summary>
/// Interface defining characteristics of Gerrhopilus (genus).
/// </summary>
public interface IGerrhopilus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
