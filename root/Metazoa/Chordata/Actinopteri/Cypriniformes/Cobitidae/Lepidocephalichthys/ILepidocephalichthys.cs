namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae.Lepidocephalichthys;

/// <summary>
/// Interface defining characteristics of Lepidocephalichthys (genus).
/// </summary>
public interface ILepidocephalichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
