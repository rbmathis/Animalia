namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Altrichthys;

/// <summary>
/// Interface defining characteristics of Altrichthys (genus).
/// </summary>
public interface IAltrichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
