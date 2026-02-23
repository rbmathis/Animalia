using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Moringuidae.Neoconger;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Moringuidae.Neoconger.unclassified_Neoconger;

/// <summary>
/// Abstract class for unclassified Neoconger (no rank).
/// NCBI TaxId: 2798280
/// </summary>
public abstract class unclassified_Neoconger : Neoconger, Iunclassified_Neoconger
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Neoconger";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2798280;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Neoconger";
}
