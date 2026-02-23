using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Lithobates;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Lithobates.unclassified_Lithobates;

/// <summary>
/// Abstract class for unclassified Lithobates (no rank).
/// NCBI TaxId: 2685383
/// </summary>
public abstract class unclassified_Lithobates : Lithobates, Iunclassified_Lithobates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lithobates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685383;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lithobates";
}
