namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Proteidae.Proteus;

/// <summary>
/// Interface defining characteristics of Proteus (genus).
/// </summary>
public interface IProteus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
