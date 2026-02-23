namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Alsodidae.Alsodes;

/// <summary>
/// Interface defining characteristics of Alsodes (genus).
/// </summary>
public interface IAlsodes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
