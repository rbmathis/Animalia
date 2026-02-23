using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ateleopodiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ateleopodiformes.unclassified_Ateleopodiformes;

/// <summary>
/// Abstract class for unclassified Ateleopodiformes (no rank).
/// NCBI TaxId: 948965
/// </summary>
public abstract class unclassified_Ateleopodiformes : Ateleopodiformes, Iunclassified_Ateleopodiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ateleopodiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 948965;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ateleopodiformes";
}
