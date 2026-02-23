namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Chaperina;

/// <summary>
/// Interface defining characteristics of Chaperina (genus).
/// </summary>
public interface IChaperina
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
