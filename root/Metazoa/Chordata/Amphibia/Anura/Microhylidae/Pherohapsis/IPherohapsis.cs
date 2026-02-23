namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Pherohapsis;

/// <summary>
/// Interface defining characteristics of Pherohapsis (genus).
/// </summary>
public interface IPherohapsis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
