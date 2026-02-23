using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinopsidae.Menidia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinopsidae.Menidia.unclassified_Menidia;

/// <summary>
/// Abstract class for unclassified Menidia (no rank).
/// NCBI TaxId: 2646852
/// </summary>
public abstract class unclassified_Menidia : Menidia, Iunclassified_Menidia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Menidia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646852;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Menidia";
}
