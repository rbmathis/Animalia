namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Platypelis;

/// <summary>
/// Interface defining characteristics of Platypelis (genus).
/// </summary>
public interface IPlatypelis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
