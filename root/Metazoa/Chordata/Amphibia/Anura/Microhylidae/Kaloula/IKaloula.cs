namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Kaloula;

/// <summary>
/// Interface defining characteristics of Kaloula (genus).
/// </summary>
public interface IKaloula
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
