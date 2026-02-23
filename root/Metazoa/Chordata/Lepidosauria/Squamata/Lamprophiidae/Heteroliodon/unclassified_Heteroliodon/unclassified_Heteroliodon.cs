using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Heteroliodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Heteroliodon.unclassified_Heteroliodon;

/// <summary>
/// Abstract class for unclassified Heteroliodon (no rank).
/// NCBI TaxId: 2618923
/// </summary>
public abstract class unclassified_Heteroliodon : Heteroliodon, Iunclassified_Heteroliodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Heteroliodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618923;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Heteroliodon";
}
