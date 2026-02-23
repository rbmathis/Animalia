namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Cryptobranchidae.Andrias;

/// <summary>
/// Interface defining characteristics of Andrias (genus).
/// </summary>
public interface IAndrias
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
