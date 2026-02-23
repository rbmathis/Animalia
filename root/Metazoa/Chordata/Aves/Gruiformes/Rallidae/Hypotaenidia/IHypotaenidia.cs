namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Hypotaenidia;

/// <summary>
/// Interface defining characteristics of Hypotaenidia (genus).
/// </summary>
public interface IHypotaenidia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
