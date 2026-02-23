namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Monodactylidae.Monodactylus;

/// <summary>
/// Interface defining characteristics of Monodactylus (genus).
/// </summary>
public interface IMonodactylus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
