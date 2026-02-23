using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Chindongo;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Chindongo.unclassified_Chindongo;

/// <summary>
/// Abstract class for unclassified Chindongo (no rank).
/// NCBI TaxId: 3385384
/// </summary>
public abstract class unclassified_Chindongo : Chindongo, Iunclassified_Chindongo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chindongo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3385384;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chindongo";
}
