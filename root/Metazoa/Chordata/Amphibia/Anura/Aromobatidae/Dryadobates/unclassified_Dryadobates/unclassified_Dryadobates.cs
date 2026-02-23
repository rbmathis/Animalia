using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Aromobatidae.Dryadobates;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Aromobatidae.Dryadobates.unclassified_Dryadobates;

/// <summary>
/// Abstract class for unclassified Dryadobates (no rank).
/// NCBI TaxId: 3436072
/// </summary>
public abstract class unclassified_Dryadobates : Dryadobates, Iunclassified_Dryadobates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dryadobates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3436072;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dryadobates";
}
