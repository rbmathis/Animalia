using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Rhamdia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Rhamdia.unclassified_Rhamdia;

/// <summary>
/// Abstract class for unclassified Rhamdia (no rank).
/// NCBI TaxId: 2602697
/// </summary>
public abstract class unclassified_Rhamdia : Rhamdia, Iunclassified_Rhamdia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhamdia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2602697;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhamdia";
}
