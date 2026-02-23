namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Bramidae.Xenobrama;

/// <summary>
/// Interface defining characteristics of Xenobrama (genus).
/// </summary>
public interface IXenobrama
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
