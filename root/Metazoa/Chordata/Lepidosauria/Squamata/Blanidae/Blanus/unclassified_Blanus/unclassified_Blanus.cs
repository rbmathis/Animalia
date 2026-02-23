using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Blanidae.Blanus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Blanidae.Blanus.unclassified_Blanus;

/// <summary>
/// Abstract class for unclassified Blanus (no rank).
/// NCBI TaxId: 2645787
/// </summary>
public abstract class unclassified_Blanus : Blanus, Iunclassified_Blanus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Blanus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645787;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Blanus";
}
