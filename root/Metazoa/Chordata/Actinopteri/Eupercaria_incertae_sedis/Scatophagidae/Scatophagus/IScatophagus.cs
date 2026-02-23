namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Scatophagidae.Scatophagus;

/// <summary>
/// Interface defining characteristics of Scatophagus (genus).
/// </summary>
public interface IScatophagus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
