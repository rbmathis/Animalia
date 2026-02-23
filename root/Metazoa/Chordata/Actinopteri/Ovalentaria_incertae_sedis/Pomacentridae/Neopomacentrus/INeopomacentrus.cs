namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Neopomacentrus;

/// <summary>
/// Interface defining characteristics of Neopomacentrus (genus).
/// </summary>
public interface INeopomacentrus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
