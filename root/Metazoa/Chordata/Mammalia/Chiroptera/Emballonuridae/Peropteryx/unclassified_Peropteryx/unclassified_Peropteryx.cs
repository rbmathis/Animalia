using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Emballonuridae.Peropteryx;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Emballonuridae.Peropteryx.unclassified_Peropteryx;

/// <summary>
/// Abstract class for unclassified Peropteryx (no rank).
/// NCBI TaxId: 2640928
/// </summary>
public abstract class unclassified_Peropteryx : Peropteryx, Iunclassified_Peropteryx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Peropteryx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640928;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Peropteryx";
}
