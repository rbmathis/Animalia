namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Rhinatrematidae.Rhinatrema;

/// <summary>
/// Interface defining characteristics of Rhinatrema (genus).
/// </summary>
public interface IRhinatrema
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
