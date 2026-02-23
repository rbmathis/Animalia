namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Hypselotriton;

/// <summary>
/// Interface defining characteristics of Hypselotriton (genus).
/// </summary>
public interface IHypselotriton
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
