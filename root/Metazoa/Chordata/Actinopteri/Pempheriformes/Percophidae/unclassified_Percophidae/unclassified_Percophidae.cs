using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pempheriformes.Percophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pempheriformes.Percophidae.unclassified_Percophidae;

/// <summary>
/// Abstract class for unclassified Percophidae (no rank).
/// NCBI TaxId: 1189044
/// </summary>
public abstract class unclassified_Percophidae : Percophidae, Iunclassified_Percophidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Percophidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1189044;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Percophidae";
}
