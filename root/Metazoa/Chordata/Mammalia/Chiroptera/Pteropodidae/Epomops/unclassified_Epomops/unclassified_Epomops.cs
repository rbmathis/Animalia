using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Epomops;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Epomops.unclassified_Epomops;

/// <summary>
/// Abstract class for unclassified Epomops (no rank).
/// NCBI TaxId: 2621561
/// </summary>
public abstract class unclassified_Epomops : Epomops, Iunclassified_Epomops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Epomops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621561;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Epomops";
}
