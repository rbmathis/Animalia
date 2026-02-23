namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Scatophagidae.Selenotoca;

/// <summary>
/// Interface defining characteristics of Selenotoca (genus).
/// </summary>
public interface ISelenotoca
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
