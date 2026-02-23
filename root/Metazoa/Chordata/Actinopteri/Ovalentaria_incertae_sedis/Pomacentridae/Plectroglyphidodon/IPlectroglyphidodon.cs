namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Plectroglyphidodon;

/// <summary>
/// Interface defining characteristics of Plectroglyphidodon (genus).
/// </summary>
public interface IPlectroglyphidodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
