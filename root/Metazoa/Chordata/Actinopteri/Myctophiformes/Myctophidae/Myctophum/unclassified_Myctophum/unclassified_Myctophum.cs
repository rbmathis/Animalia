using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Myctophum;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Myctophum.unclassified_Myctophum;

/// <summary>
/// Abstract class for unclassified Myctophum (no rank).
/// NCBI TaxId: 2644268
/// </summary>
public abstract class unclassified_Myctophum : Myctophum, Iunclassified_Myctophum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Myctophum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644268;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Myctophum";
}
