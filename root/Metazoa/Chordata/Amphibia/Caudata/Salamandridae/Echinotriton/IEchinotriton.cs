namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Echinotriton;

/// <summary>
/// Interface defining characteristics of Echinotriton (genus).
/// </summary>
public interface IEchinotriton
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
