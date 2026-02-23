using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Panaspis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Panaspis.unclassified_Panaspis;

/// <summary>
/// Abstract class for unclassified Panaspis (no rank).
/// NCBI TaxId: 1810309
/// </summary>
public abstract class unclassified_Panaspis : Panaspis, Iunclassified_Panaspis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Panaspis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1810309;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Panaspis";
}
