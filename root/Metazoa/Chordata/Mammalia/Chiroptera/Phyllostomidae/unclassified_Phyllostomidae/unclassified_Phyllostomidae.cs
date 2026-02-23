using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.unclassified_Phyllostomidae;

/// <summary>
/// Abstract class for unclassified Phyllostomidae (no rank).
/// NCBI TaxId: 3242306
/// </summary>
public abstract class unclassified_Phyllostomidae : Phyllostomidae, Iunclassified_Phyllostomidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phyllostomidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3242306;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phyllostomidae";
}
