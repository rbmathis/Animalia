using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Suidae.Sus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Suidae.Sus.unclassified_Sus;

/// <summary>
/// Abstract class for unclassified Sus (no rank).
/// NCBI TaxId: 432588
/// </summary>
public abstract class unclassified_Sus : Sus, Iunclassified_Sus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 432588;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sus";
}
