using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.unclassified_Hypoptopomatinae;

/// <summary>
/// Abstract class for unclassified Hypoptopomatinae (no rank).
/// NCBI TaxId: 747053
/// </summary>
public abstract class unclassified_Hypoptopomatinae : Loricariidae, Iunclassified_Hypoptopomatinae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hypoptopomatinae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 747053;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hypoptopomatinae";
}
