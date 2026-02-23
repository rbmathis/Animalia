using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Eulamprus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Eulamprus.unclassified_Eulamprus;

/// <summary>
/// Abstract class for unclassified Eulamprus (no rank).
/// NCBI TaxId: 2630475
/// </summary>
public abstract class unclassified_Eulamprus : Eulamprus, Iunclassified_Eulamprus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Eulamprus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630475;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Eulamprus";
}
