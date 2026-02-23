using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Larutia;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Larutia.unclassified_Larutia;

/// <summary>
/// Abstract class for unclassified Larutia (no rank).
/// NCBI TaxId: 2677335
/// </summary>
public abstract class unclassified_Larutia : Larutia, Iunclassified_Larutia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Larutia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677335;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Larutia";
}
