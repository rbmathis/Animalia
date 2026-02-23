namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Shinisauridae.Shinisaurus;

/// <summary>
/// Interface defining characteristics of Shinisaurus (genus).
/// </summary>
public interface IShinisaurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
