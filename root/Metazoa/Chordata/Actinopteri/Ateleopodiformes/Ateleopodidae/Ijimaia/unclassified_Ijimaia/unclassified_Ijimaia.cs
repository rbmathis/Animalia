using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ateleopodiformes.Ateleopodidae.Ijimaia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ateleopodiformes.Ateleopodidae.Ijimaia.unclassified_Ijimaia;

/// <summary>
/// Abstract class for unclassified Ijimaia (no rank).
/// NCBI TaxId: 3074025
/// </summary>
public abstract class unclassified_Ijimaia : Ijimaia, Iunclassified_Ijimaia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ijimaia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3074025;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ijimaia";
}
