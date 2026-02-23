using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Chaenopsidae.Emblemariopsis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Chaenopsidae.Emblemariopsis.unclassified_Emblemariopsis;

/// <summary>
/// Abstract class for unclassified Emblemariopsis (no rank).
/// NCBI TaxId: 2624308
/// </summary>
public abstract class unclassified_Emblemariopsis : Emblemariopsis, Iunclassified_Emblemariopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Emblemariopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624308;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Emblemariopsis";
}
