using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae.Acutotyphlops;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae.Acutotyphlops.unclassified_Acutotyphlops;

/// <summary>
/// Abstract class for unclassified Acutotyphlops (no rank).
/// NCBI TaxId: 2646821
/// </summary>
public abstract class unclassified_Acutotyphlops : Acutotyphlops, Iunclassified_Acutotyphlops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Acutotyphlops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646821;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Acutotyphlops";
}
