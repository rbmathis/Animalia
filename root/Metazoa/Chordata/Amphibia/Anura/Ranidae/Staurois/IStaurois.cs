namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Staurois;

/// <summary>
/// Interface defining characteristics of Staurois (genus).
/// </summary>
public interface IStaurois
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
