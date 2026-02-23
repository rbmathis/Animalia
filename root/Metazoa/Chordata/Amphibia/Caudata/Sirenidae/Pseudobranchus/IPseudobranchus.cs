namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Sirenidae.Pseudobranchus;

/// <summary>
/// Interface defining characteristics of Pseudobranchus (genus).
/// </summary>
public interface IPseudobranchus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
