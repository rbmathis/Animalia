using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Riopa;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Riopa.unclassified_Riopa_in_lizards__snakes;

/// <summary>
/// Abstract class for unclassified Riopa (in: lizards & snakes) (no rank).
/// NCBI TaxId: 3028241
/// </summary>
public abstract class unclassified_Riopa_in_lizards__snakes : Riopa, Iunclassified_Riopa_in_lizards__snakes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Riopa (in: lizards & snakes)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3028241;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Riopa_in_lizards__snakes";
}
