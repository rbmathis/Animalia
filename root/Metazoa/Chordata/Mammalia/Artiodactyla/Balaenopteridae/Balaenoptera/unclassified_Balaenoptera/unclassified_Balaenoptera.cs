using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Balaenopteridae.Balaenoptera;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Balaenopteridae.Balaenoptera.unclassified_Balaenoptera;

/// <summary>
/// Abstract class for unclassified Balaenoptera (no rank).
/// NCBI TaxId: 2635866
/// </summary>
public abstract class unclassified_Balaenoptera : Balaenoptera, Iunclassified_Balaenoptera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Balaenoptera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635866;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Balaenoptera";
}
