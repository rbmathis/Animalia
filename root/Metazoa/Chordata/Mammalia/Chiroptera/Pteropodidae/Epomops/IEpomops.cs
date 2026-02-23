namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Epomops;

/// <summary>
/// Interface defining characteristics of Epomops (genus).
/// </summary>
public interface IEpomops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
