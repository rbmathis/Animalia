using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Trachylepis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Trachylepis.unclassified_Trachylepis;

/// <summary>
/// Abstract class for unclassified Trachylepis (no rank).
/// NCBI TaxId: 2637017
/// </summary>
public abstract class unclassified_Trachylepis : Trachylepis, Iunclassified_Trachylepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Trachylepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637017;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Trachylepis";
}
