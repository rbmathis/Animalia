using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae.Xenotyphlops;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae.Xenotyphlops.unclassified_Xenotyphlops;

/// <summary>
/// Abstract class for unclassified Xenotyphlops (no rank).
/// NCBI TaxId: 2621449
/// </summary>
public abstract class unclassified_Xenotyphlops : Xenotyphlops, Iunclassified_Xenotyphlops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Xenotyphlops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621449;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Xenotyphlops";
}
