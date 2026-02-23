namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Bolitoglossa;

/// <summary>
/// Interface defining characteristics of Bolitoglossa (genus).
/// </summary>
public interface IBolitoglossa
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
