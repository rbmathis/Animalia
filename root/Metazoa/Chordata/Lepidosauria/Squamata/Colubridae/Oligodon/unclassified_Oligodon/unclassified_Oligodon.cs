using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Oligodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Oligodon.unclassified_Oligodon;

/// <summary>
/// Abstract class for unclassified Oligodon (no rank).
/// NCBI TaxId: 2684964
/// </summary>
public abstract class unclassified_Oligodon : Oligodon, Iunclassified_Oligodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Oligodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2684964;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Oligodon";
}
