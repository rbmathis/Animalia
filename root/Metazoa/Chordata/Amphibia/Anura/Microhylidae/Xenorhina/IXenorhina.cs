namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Xenorhina;

/// <summary>
/// Interface defining characteristics of Xenorhina (genus).
/// </summary>
public interface IXenorhina
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
