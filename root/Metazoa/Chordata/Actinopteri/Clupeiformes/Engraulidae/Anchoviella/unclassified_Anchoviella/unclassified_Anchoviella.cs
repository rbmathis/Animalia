using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae.Anchoviella;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae.Anchoviella.unclassified_Anchoviella;

/// <summary>
/// Abstract class for unclassified Anchoviella (no rank).
/// NCBI TaxId: 2646210
/// </summary>
public abstract class unclassified_Anchoviella : Anchoviella, Iunclassified_Anchoviella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Anchoviella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646210;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Anchoviella";
}
