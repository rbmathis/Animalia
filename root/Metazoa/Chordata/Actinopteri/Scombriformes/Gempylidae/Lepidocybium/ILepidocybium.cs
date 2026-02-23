namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Gempylidae.Lepidocybium;

/// <summary>
/// Interface defining characteristics of Lepidocybium (genus).
/// </summary>
public interface ILepidocybium
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
