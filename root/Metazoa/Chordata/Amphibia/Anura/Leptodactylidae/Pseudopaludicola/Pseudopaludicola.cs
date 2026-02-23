using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Pseudopaludicola;

/// <summary>
/// Abstract class for Pseudopaludicola (genus).
/// NCBI TaxId: 318410
/// </summary>
public abstract class Pseudopaludicola : Leptodactylidae, IPseudopaludicola
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudopaludicola";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 318410;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudopaludicola";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
