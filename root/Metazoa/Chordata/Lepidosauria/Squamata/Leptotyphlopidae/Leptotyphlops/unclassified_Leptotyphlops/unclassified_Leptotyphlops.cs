using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leptotyphlopidae.Leptotyphlops;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leptotyphlopidae.Leptotyphlops.unclassified_Leptotyphlops;

/// <summary>
/// Abstract class for unclassified Leptotyphlops (no rank).
/// NCBI TaxId: 2649958
/// </summary>
public abstract class unclassified_Leptotyphlops : Leptotyphlops, Iunclassified_Leptotyphlops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Leptotyphlops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649958;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Leptotyphlops";
}
