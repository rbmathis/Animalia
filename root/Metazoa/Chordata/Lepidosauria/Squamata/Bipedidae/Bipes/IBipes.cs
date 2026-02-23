namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Bipedidae.Bipes;

/// <summary>
/// Interface defining characteristics of Bipes (genus).
/// </summary>
public interface IBipes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
