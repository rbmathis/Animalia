using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Minyobates;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Minyobates.unclassified_Minyobates;

/// <summary>
/// Abstract class for unclassified Minyobates (no rank).
/// NCBI TaxId: 2637266
/// </summary>
public abstract class unclassified_Minyobates : Minyobates, Iunclassified_Minyobates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Minyobates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637266;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Minyobates";
}
