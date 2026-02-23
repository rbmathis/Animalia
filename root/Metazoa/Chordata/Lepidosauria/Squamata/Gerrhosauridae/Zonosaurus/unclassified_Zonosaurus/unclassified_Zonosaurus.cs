using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gerrhosauridae.Zonosaurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gerrhosauridae.Zonosaurus.unclassified_Zonosaurus;

/// <summary>
/// Abstract class for unclassified Zonosaurus (no rank).
/// NCBI TaxId: 2618357
/// </summary>
public abstract class unclassified_Zonosaurus : Zonosaurus, Iunclassified_Zonosaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Zonosaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618357;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Zonosaurus";
}
