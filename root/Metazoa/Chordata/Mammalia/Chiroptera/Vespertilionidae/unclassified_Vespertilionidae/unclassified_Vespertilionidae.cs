using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.unclassified_Vespertilionidae;

/// <summary>
/// Abstract class for unclassified Vespertilionidae (no rank).
/// NCBI TaxId: 1296580
/// </summary>
public abstract class unclassified_Vespertilionidae : Vespertilionidae, Iunclassified_Vespertilionidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Vespertilionidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1296580;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Vespertilionidae";
}
