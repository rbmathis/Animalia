namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Pseudopaludicola;

/// <summary>
/// Interface defining characteristics of Pseudopaludicola (genus).
/// </summary>
public interface IPseudopaludicola
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
