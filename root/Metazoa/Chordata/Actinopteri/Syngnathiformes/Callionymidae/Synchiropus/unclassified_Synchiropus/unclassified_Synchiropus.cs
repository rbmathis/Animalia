using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Callionymidae.Synchiropus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Callionymidae.Synchiropus.unclassified_Synchiropus;

/// <summary>
/// Abstract class for unclassified Synchiropus (no rank).
/// NCBI TaxId: 2628833
/// </summary>
public abstract class unclassified_Synchiropus : Synchiropus, Iunclassified_Synchiropus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Synchiropus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628833;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Synchiropus";
}
