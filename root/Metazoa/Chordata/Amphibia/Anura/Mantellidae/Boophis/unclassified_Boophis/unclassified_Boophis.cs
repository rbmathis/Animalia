using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae.Boophis;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae.Boophis.unclassified_Boophis;

/// <summary>
/// Abstract class for unclassified Boophis (no rank).
/// NCBI TaxId: 410328
/// </summary>
public abstract class unclassified_Boophis : Boophis, Iunclassified_Boophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Boophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 410328;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Boophis";
}
