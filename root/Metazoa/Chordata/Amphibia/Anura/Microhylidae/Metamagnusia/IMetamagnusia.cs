namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Metamagnusia;

/// <summary>
/// Interface defining characteristics of Metamagnusia (genus).
/// </summary>
public interface IMetamagnusia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
