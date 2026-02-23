using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.unclassified_Pristellinae;

/// <summary>
/// Abstract class for unclassified Pristellinae (no rank).
/// NCBI TaxId: 1828397
/// </summary>
public abstract class unclassified_Pristellinae : Acestrorhamphidae, Iunclassified_Pristellinae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pristellinae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1828397;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pristellinae";
}
