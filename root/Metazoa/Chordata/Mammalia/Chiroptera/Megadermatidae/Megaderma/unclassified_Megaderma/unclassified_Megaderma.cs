using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Megadermatidae.Megaderma;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Megadermatidae.Megaderma.unclassified_Megaderma;

/// <summary>
/// Abstract class for unclassified Megaderma (no rank).
/// NCBI TaxId: 3242302
/// </summary>
public abstract class unclassified_Megaderma : Megaderma, Iunclassified_Megaderma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Megaderma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3242302;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Megaderma";
}
