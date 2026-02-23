namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Paramesotriton;

/// <summary>
/// Interface defining characteristics of Paramesotriton (genus).
/// </summary>
public interface IParamesotriton
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
