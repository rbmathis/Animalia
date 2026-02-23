using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Rhynchoconger;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Rhynchoconger.unclassified_Rhynchoconger;

/// <summary>
/// Abstract class for unclassified Rhynchoconger (no rank).
/// NCBI TaxId: 2641474
/// </summary>
public abstract class unclassified_Rhynchoconger : Rhynchoconger, Iunclassified_Rhynchoconger
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhynchoconger";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641474;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhynchoconger";
}
