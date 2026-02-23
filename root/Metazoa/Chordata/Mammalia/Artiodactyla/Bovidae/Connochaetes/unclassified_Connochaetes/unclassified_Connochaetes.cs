using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Connochaetes;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Connochaetes.unclassified_Connochaetes;

/// <summary>
/// Abstract class for unclassified Connochaetes (no rank).
/// NCBI TaxId: 2634448
/// </summary>
public abstract class unclassified_Connochaetes : Connochaetes, Iunclassified_Connochaetes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Connochaetes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634448;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Connochaetes";
}
