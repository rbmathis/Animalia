using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Panaque;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Panaque.unclassified_Panaque;

/// <summary>
/// Abstract class for unclassified Panaque (no rank).
/// NCBI TaxId: 2640350
/// </summary>
public abstract class unclassified_Panaque : Panaque, Iunclassified_Panaque
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Panaque";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640350;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Panaque";
}
