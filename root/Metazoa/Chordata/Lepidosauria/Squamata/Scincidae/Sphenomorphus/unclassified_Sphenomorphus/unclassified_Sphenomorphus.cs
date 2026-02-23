using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Sphenomorphus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Sphenomorphus.unclassified_Sphenomorphus;

/// <summary>
/// Abstract class for unclassified Sphenomorphus (no rank).
/// NCBI TaxId: 2685222
/// </summary>
public abstract class unclassified_Sphenomorphus : Sphenomorphus, Iunclassified_Sphenomorphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sphenomorphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685222;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sphenomorphus";
}
