using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Varanidae.Varanus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Varanidae.Varanus.unclassified_Varanus;

/// <summary>
/// Abstract class for unclassified Varanus (no rank).
/// NCBI TaxId: 2646793
/// </summary>
public abstract class unclassified_Varanus : Varanus, Iunclassified_Varanus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Varanus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646793;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Varanus";
}
