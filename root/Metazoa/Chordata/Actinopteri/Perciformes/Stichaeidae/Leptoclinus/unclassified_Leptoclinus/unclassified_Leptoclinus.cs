using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae.Leptoclinus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae.Leptoclinus.unclassified_Leptoclinus;

/// <summary>
/// Abstract class for unclassified Leptoclinus (no rank).
/// NCBI TaxId: 2816477
/// </summary>
public abstract class unclassified_Leptoclinus : Leptoclinus, Iunclassified_Leptoclinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Leptoclinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2816477;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Leptoclinus";
}
