using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Leptorhamdia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Leptorhamdia.unclassified_Leptorhamdia;

/// <summary>
/// Abstract class for unclassified Leptorhamdia (no rank).
/// NCBI TaxId: 2821975
/// </summary>
public abstract class unclassified_Leptorhamdia : Leptorhamdia, Iunclassified_Leptorhamdia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Leptorhamdia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2821975;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Leptorhamdia";
}
