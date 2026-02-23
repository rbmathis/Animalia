namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Paucituberculata.Caenolestidae.Rhyncholestes;

/// <summary>
/// Interface defining characteristics of Rhyncholestes (genus).
/// </summary>
public interface IRhyncholestes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
