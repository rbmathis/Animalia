namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Batoidea_incertae_sedis.Platyrhinidae.Platyrhinoidis;

/// <summary>
/// Interface defining characteristics of Platyrhinoidis (genus).
/// </summary>
public interface IPlatyrhinoidis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
