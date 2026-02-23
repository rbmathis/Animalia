using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Lasiurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Lasiurus.unclassified_Lasiurus_in_bats;

/// <summary>
/// Abstract class for unclassified Lasiurus (in: bats) (no rank).
/// NCBI TaxId: 2688611
/// </summary>
public abstract class unclassified_Lasiurus_in_bats : Lasiurus, Iunclassified_Lasiurus_in_bats
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lasiurus (in: bats)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2688611;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lasiurus_in_bats";
}
