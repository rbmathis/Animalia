using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Chlamyphoridae.Glyptodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Chlamyphoridae.Glyptodon.unclassified_Glyptodon;

/// <summary>
/// Abstract class for unclassified Glyptodon (no rank).
/// NCBI TaxId: 2642837
/// </summary>
public abstract class unclassified_Glyptodon : Glyptodon, Iunclassified_Glyptodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Glyptodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642837;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Glyptodon";
}
