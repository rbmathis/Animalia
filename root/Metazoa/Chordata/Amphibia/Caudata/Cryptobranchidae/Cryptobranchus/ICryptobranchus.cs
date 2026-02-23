namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Cryptobranchidae.Cryptobranchus;

/// <summary>
/// Interface defining characteristics of Cryptobranchus (genus).
/// </summary>
public interface ICryptobranchus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
