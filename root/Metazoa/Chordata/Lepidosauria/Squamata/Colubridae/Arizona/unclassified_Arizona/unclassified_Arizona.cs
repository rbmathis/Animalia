using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Arizona;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Arizona.unclassified_Arizona;

/// <summary>
/// Abstract class for unclassified Arizona (no rank).
/// NCBI TaxId: 2878750
/// </summary>
public abstract class unclassified_Arizona : Arizona, Iunclassified_Arizona
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Arizona";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2878750;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Arizona";
}
