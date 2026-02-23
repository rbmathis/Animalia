using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Lycodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Lycodon.unclassified_Lycodon;

/// <summary>
/// Abstract class for unclassified Lycodon (no rank).
/// NCBI TaxId: 2635458
/// </summary>
public abstract class unclassified_Lycodon : Lycodon, Iunclassified_Lycodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lycodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635458;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lycodon";
}
