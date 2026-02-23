using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Petauridae.Petaurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Petauridae.Petaurus.unclassified_Petaurus;

/// <summary>
/// Abstract class for unclassified Petaurus (no rank).
/// NCBI TaxId: 2748636
/// </summary>
public abstract class unclassified_Petaurus : Petaurus, Iunclassified_Petaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Petaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2748636;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Petaurus";
}
