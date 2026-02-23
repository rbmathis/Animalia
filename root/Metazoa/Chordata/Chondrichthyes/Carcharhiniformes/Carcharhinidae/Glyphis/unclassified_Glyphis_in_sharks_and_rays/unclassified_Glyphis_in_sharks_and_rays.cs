using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Carcharhinidae.Glyphis;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Carcharhinidae.Glyphis.unclassified_Glyphis_in_sharks_and_rays;

/// <summary>
/// Abstract class for unclassified Glyphis (in: sharks and rays) (no rank).
/// NCBI TaxId: 2688513
/// </summary>
public abstract class unclassified_Glyphis_in_sharks_and_rays : Glyphis, Iunclassified_Glyphis_in_sharks_and_rays
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Glyphis (in: sharks and rays)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2688513;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Glyphis_in_sharks_and_rays";
}
