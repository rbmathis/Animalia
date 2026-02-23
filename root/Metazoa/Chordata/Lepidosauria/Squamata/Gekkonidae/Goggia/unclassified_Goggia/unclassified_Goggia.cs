using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Goggia;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Goggia.unclassified_Goggia;

/// <summary>
/// Abstract class for unclassified Goggia (no rank).
/// NCBI TaxId: 3402742
/// </summary>
public abstract class unclassified_Goggia : Goggia, Iunclassified_Goggia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Goggia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3402742;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Goggia";
}
