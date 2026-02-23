using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Eptesicus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Eptesicus.unclassified_Eptesicus;

/// <summary>
/// Abstract class for unclassified Eptesicus (no rank).
/// NCBI TaxId: 2643748
/// </summary>
public abstract class unclassified_Eptesicus : Eptesicus, Iunclassified_Eptesicus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Eptesicus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643748;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Eptesicus";
}
