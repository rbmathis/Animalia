using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Pteropus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Pteropus.unclassified_Pteropus;

/// <summary>
/// Abstract class for unclassified Pteropus (no rank).
/// NCBI TaxId: 2647550
/// </summary>
public abstract class unclassified_Pteropus : Pteropus, Iunclassified_Pteropus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pteropus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647550;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pteropus";
}
