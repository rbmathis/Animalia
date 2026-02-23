using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Cryptonanus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Cryptonanus.unclassified_Cryptonanus;

/// <summary>
/// Abstract class for unclassified Cryptonanus (no rank).
/// NCBI TaxId: 2625093
/// </summary>
public abstract class unclassified_Cryptonanus : Cryptonanus, Iunclassified_Cryptonanus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cryptonanus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625093;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cryptonanus";
}
