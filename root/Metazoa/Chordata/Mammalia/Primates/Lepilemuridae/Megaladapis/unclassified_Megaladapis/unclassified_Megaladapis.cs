using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lepilemuridae.Megaladapis;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lepilemuridae.Megaladapis.unclassified_Megaladapis;

/// <summary>
/// Abstract class for unclassified Megaladapis (no rank).
/// NCBI TaxId: 2620125
/// </summary>
public abstract class unclassified_Megaladapis : Megaladapis, Iunclassified_Megaladapis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Megaladapis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620125;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Megaladapis";
}
