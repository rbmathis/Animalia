namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Copiula;

/// <summary>
/// Interface defining characteristics of Copiula (genus).
/// </summary>
public interface ICopiula
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
