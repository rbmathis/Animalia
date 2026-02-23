using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Aromobatidae.Aromobates;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Aromobatidae.Aromobates.unclassified_Aromobates;

/// <summary>
/// Abstract class for unclassified Aromobates (no rank).
/// NCBI TaxId: 2685368
/// </summary>
public abstract class unclassified_Aromobates : Aromobates, Iunclassified_Aromobates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aromobates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685368;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aromobates";
}
