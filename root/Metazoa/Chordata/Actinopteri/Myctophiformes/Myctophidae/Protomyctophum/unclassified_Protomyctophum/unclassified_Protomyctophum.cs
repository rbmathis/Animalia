using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Protomyctophum;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Protomyctophum.unclassified_Protomyctophum;

/// <summary>
/// Abstract class for unclassified Protomyctophum (no rank).
/// NCBI TaxId: 2630491
/// </summary>
public abstract class unclassified_Protomyctophum : Protomyctophum, Iunclassified_Protomyctophum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Protomyctophum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630491;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Protomyctophum";
}
