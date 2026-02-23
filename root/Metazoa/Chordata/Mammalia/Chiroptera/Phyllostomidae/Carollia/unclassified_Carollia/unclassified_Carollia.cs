using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Carollia;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Carollia.unclassified_Carollia;

/// <summary>
/// Abstract class for unclassified Carollia (no rank).
/// NCBI TaxId: 2646434
/// </summary>
public abstract class unclassified_Carollia : Carollia, Iunclassified_Carollia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Carollia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646434;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Carollia";
}
