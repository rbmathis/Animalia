namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Batoidea_incertae_sedis.Platyrhinidae.Platyrhina;

/// <summary>
/// Interface defining characteristics of Platyrhina (genus).
/// </summary>
public interface IPlatyrhina
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
