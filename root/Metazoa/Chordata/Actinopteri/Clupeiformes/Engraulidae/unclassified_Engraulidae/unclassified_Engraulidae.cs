using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae.unclassified_Engraulidae;

/// <summary>
/// Abstract class for unclassified Engraulidae (no rank).
/// NCBI TaxId: 722545
/// </summary>
public abstract class unclassified_Engraulidae : Engraulidae, Iunclassified_Engraulidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Engraulidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 722545;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Engraulidae";
}
