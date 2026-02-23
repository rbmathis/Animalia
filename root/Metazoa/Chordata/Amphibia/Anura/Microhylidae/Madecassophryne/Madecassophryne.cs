using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Madecassophryne;

/// <summary>
/// Abstract class for Madecassophryne (genus).
/// NCBI TaxId: 2066432
/// </summary>
public abstract class Madecassophryne : Microhylidae, IMadecassophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Madecassophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2066432;

    /// <inheritdoc />
    public virtual string GenusName => "Madecassophryne";

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
