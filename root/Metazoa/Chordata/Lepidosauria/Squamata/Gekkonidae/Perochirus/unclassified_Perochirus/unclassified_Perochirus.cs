using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Perochirus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Perochirus.unclassified_Perochirus;

/// <summary>
/// Abstract class for unclassified Perochirus (no rank).
/// NCBI TaxId: 2625220
/// </summary>
public abstract class unclassified_Perochirus : Perochirus, Iunclassified_Perochirus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Perochirus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625220;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Perochirus";
}
