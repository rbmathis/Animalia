using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Pristigasteridae.Ilisha;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Pristigasteridae.Ilisha.unclassified_Ilisha;

/// <summary>
/// Abstract class for unclassified Ilisha (no rank).
/// NCBI TaxId: 2627232
/// </summary>
public abstract class unclassified_Ilisha : Ilisha, Iunclassified_Ilisha
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ilisha";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627232;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ilisha";
}
