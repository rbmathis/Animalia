using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Nannoscincus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Nannoscincus.unclassified_Nannoscincus;

/// <summary>
/// Abstract class for unclassified Nannoscincus (no rank).
/// NCBI TaxId: 2620579
/// </summary>
public abstract class unclassified_Nannoscincus : Nannoscincus, Iunclassified_Nannoscincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nannoscincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620579;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nannoscincus";
}
