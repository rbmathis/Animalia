namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Tepuihyla;

/// <summary>
/// Interface defining characteristics of Tepuihyla (genus).
/// </summary>
public interface ITepuihyla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
