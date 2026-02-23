using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Lophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Lophiidae.unclassified_Lophiidae;

/// <summary>
/// Abstract class for unclassified Lophiidae (no rank).
/// NCBI TaxId: 3071816
/// </summary>
public abstract class unclassified_Lophiidae : Lophiidae, Iunclassified_Lophiidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lophiidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3071816;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lophiidae";
}
