namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Physalaemus;

/// <summary>
/// Interface defining characteristics of Physalaemus (genus).
/// </summary>
public interface IPhysalaemus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
