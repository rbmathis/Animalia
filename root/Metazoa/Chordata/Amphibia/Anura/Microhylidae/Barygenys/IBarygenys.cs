namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Barygenys;

/// <summary>
/// Interface defining characteristics of Barygenys (genus).
/// </summary>
public interface IBarygenys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
