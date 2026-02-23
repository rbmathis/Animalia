using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Miniopteridae.Miniopterus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Miniopteridae.Miniopterus.unclassified_Miniopterus;

/// <summary>
/// Abstract class for unclassified Miniopterus (no rank).
/// NCBI TaxId: 2645810
/// </summary>
public abstract class unclassified_Miniopterus : Miniopterus, Iunclassified_Miniopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Miniopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645810;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Miniopterus";
}
