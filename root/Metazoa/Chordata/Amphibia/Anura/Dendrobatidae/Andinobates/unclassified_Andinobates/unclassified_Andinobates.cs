using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Andinobates;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Andinobates.unclassified_Andinobates;

/// <summary>
/// Abstract class for unclassified Andinobates (no rank).
/// NCBI TaxId: 2647288
/// </summary>
public abstract class unclassified_Andinobates : Andinobates, Iunclassified_Andinobates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Andinobates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647288;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Andinobates";
}
