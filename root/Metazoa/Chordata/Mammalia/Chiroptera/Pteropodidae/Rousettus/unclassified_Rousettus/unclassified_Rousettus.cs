using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Rousettus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Rousettus.unclassified_Rousettus;

/// <summary>
/// Abstract class for unclassified Rousettus (no rank).
/// NCBI TaxId: 2640345
/// </summary>
public abstract class unclassified_Rousettus : Rousettus, Iunclassified_Rousettus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rousettus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640345;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rousettus";
}
