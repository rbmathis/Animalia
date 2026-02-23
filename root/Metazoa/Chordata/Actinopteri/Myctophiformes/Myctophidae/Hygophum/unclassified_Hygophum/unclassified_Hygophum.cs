using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Hygophum;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Hygophum.unclassified_Hygophum;

/// <summary>
/// Abstract class for unclassified Hygophum (no rank).
/// NCBI TaxId: 2641075
/// </summary>
public abstract class unclassified_Hygophum : Hygophum, Iunclassified_Hygophum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hygophum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641075;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hygophum";
}
