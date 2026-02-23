using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Oneirodidae.Spiniphryne;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Oneirodidae.Spiniphryne.unclassified_Spiniphryne;

/// <summary>
/// Abstract class for unclassified Spiniphryne (no rank).
/// NCBI TaxId: 2637701
/// </summary>
public abstract class unclassified_Spiniphryne : Spiniphryne, Iunclassified_Spiniphryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Spiniphryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637701;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Spiniphryne";
}
