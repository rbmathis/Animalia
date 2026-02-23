using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Octodontidae.Octodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Octodontidae.Octodon.unclassified_Octodon;

/// <summary>
/// Abstract class for unclassified Octodon (no rank).
/// NCBI TaxId: 2644789
/// </summary>
public abstract class unclassified_Octodon : Octodon, Iunclassified_Octodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Octodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644789;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Octodon";
}
