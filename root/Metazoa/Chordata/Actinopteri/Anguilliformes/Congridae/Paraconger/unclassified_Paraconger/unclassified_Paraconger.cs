using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Paraconger;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Paraconger.unclassified_Paraconger;

/// <summary>
/// Abstract class for unclassified Paraconger (no rank).
/// NCBI TaxId: 2726567
/// </summary>
public abstract class unclassified_Paraconger : Paraconger, Iunclassified_Paraconger
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paraconger";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2726567;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paraconger";
}
