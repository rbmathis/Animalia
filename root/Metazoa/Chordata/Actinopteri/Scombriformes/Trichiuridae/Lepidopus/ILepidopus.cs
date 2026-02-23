namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Trichiuridae.Lepidopus;

/// <summary>
/// Interface defining characteristics of Lepidopus (genus).
/// </summary>
public interface ILepidopus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
