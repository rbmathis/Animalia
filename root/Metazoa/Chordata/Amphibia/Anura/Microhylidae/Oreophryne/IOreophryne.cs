namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Oreophryne;

/// <summary>
/// Interface defining characteristics of Oreophryne (genus).
/// </summary>
public interface IOreophryne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
