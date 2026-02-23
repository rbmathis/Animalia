namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Pycnochromis;

/// <summary>
/// Interface defining characteristics of Pycnochromis (genus).
/// </summary>
public interface IPycnochromis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
