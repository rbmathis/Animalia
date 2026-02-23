using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pempheriformes.Percophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pempheriformes.Percophidae.unclassified_Bembropinae;

/// <summary>
/// Abstract class for unclassified Bembropinae (no rank).
/// NCBI TaxId: 1781139
/// </summary>
public abstract class unclassified_Bembropinae : Percophidae, Iunclassified_Bembropinae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bembropinae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1781139;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bembropinae";
}
