using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Mullidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Mullidae.unclassified_Mullidae;

/// <summary>
/// Abstract class for unclassified Mullidae (no rank).
/// NCBI TaxId: 1182092
/// </summary>
public abstract class unclassified_Mullidae : Mullidae, Iunclassified_Mullidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mullidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1182092;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mullidae";
}
