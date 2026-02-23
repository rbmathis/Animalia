using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Sturnira;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Sturnira.unclassified_Sturnira;

/// <summary>
/// Abstract class for unclassified Sturnira (no rank).
/// NCBI TaxId: 2631065
/// </summary>
public abstract class unclassified_Sturnira : Sturnira, Iunclassified_Sturnira
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sturnira";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631065;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sturnira";
}
