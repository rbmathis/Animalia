using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Sirenia;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Sirenia.unclassified_Sirenia;

/// <summary>
/// Abstract class for unclassified Sirenia (no rank).
/// NCBI TaxId: 948980
/// </summary>
public abstract class unclassified_Sirenia : Sirenia, Iunclassified_Sirenia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sirenia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 948980;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sirenia";
}
