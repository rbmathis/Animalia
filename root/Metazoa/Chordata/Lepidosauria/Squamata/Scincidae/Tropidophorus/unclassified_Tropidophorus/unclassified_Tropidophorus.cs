using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Tropidophorus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Tropidophorus.unclassified_Tropidophorus;

/// <summary>
/// Abstract class for unclassified Tropidophorus (no rank).
/// NCBI TaxId: 2685040
/// </summary>
public abstract class unclassified_Tropidophorus : Tropidophorus, Iunclassified_Tropidophorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tropidophorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685040;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tropidophorus";
}
