using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Phenacorhamdia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Phenacorhamdia.unclassified_Phenacorhamdia;

/// <summary>
/// Abstract class for unclassified Phenacorhamdia (no rank).
/// NCBI TaxId: 2829554
/// </summary>
public abstract class unclassified_Phenacorhamdia : Phenacorhamdia, Iunclassified_Phenacorhamdia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phenacorhamdia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2829554;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phenacorhamdia";
}
