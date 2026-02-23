using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Chaenopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Chaenopsidae.unclassified_Chaenopsidae;

/// <summary>
/// Abstract class for unclassified Chaenopsidae (no rank).
/// NCBI TaxId: 722544
/// </summary>
public abstract class unclassified_Chaenopsidae : Chaenopsidae, Iunclassified_Chaenopsidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chaenopsidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 722544;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chaenopsidae";
}
