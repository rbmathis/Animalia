using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Cordylidae.Platysaurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Cordylidae.Platysaurus.unclassified_Platysaurus;

/// <summary>
/// Abstract class for unclassified Platysaurus (no rank).
/// NCBI TaxId: 2645472
/// </summary>
public abstract class unclassified_Platysaurus : Platysaurus, Iunclassified_Platysaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Platysaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645472;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Platysaurus";
}
