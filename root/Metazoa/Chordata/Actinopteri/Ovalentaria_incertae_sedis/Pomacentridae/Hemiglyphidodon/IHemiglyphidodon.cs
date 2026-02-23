namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Hemiglyphidodon;

/// <summary>
/// Interface defining characteristics of Hemiglyphidodon (genus).
/// </summary>
public interface IHemiglyphidodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
