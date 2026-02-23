namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Huia;

/// <summary>
/// Interface defining characteristics of Huia (genus).
/// </summary>
public interface IHuia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
