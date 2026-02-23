using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Lophiidae.Lophius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Lophiidae.Lophius.unclassified_Lophius;

/// <summary>
/// Abstract class for unclassified Lophius (no rank).
/// NCBI TaxId: 2640923
/// </summary>
public abstract class unclassified_Lophius : Lophius, Iunclassified_Lophius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lophius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640923;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lophius";
}
