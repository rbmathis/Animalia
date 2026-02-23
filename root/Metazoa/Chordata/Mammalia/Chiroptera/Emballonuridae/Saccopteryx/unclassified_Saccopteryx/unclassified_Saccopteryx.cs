using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Emballonuridae.Saccopteryx;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Emballonuridae.Saccopteryx.unclassified_Saccopteryx;

/// <summary>
/// Abstract class for unclassified Saccopteryx (no rank).
/// NCBI TaxId: 2633232
/// </summary>
public abstract class unclassified_Saccopteryx : Saccopteryx, Iunclassified_Saccopteryx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Saccopteryx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633232;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Saccopteryx";
}
