using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Chlopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Chlopsidae.unclassified_Chlopsidae;

/// <summary>
/// Abstract class for unclassified Chlopsidae (no rank).
/// NCBI TaxId: 2861097
/// </summary>
public abstract class unclassified_Chlopsidae : Chlopsidae, Iunclassified_Chlopsidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chlopsidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2861097;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chlopsidae";
}
