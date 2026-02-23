using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Platypelis;

/// <summary>
/// Abstract class for Platypelis (genus).
/// NCBI TaxId: 143633
/// </summary>
public abstract class Platypelis : Microhylidae, IPlatypelis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Platypelis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143633;

    /// <inheritdoc />
    public virtual string GenusName => "Platypelis";

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
