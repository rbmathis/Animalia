namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Taruga;

/// <summary>
/// Interface defining characteristics of Taruga (genus).
/// </summary>
public interface ITaruga
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
