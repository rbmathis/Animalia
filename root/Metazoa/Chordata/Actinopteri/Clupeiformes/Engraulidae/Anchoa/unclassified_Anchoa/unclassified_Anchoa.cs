using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae.Anchoa;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae.Anchoa.unclassified_Anchoa;

/// <summary>
/// Abstract class for unclassified Anchoa (no rank).
/// NCBI TaxId: 2644053
/// </summary>
public abstract class unclassified_Anchoa : Anchoa, Iunclassified_Anchoa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Anchoa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644053;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Anchoa";
}
