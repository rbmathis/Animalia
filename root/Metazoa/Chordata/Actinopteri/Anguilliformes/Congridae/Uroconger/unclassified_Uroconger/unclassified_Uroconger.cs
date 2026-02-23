using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Uroconger;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Uroconger.unclassified_Uroconger;

/// <summary>
/// Abstract class for unclassified Uroconger (no rank).
/// NCBI TaxId: 2645715
/// </summary>
public abstract class unclassified_Uroconger : Uroconger, Iunclassified_Uroconger
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Uroconger";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645715;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Uroconger";
}
