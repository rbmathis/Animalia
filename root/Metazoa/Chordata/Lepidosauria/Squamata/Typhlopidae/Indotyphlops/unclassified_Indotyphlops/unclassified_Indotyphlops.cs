using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae.Indotyphlops;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae.Indotyphlops.unclassified_Indotyphlops;

/// <summary>
/// Abstract class for unclassified Indotyphlops (no rank).
/// NCBI TaxId: 2630448
/// </summary>
public abstract class unclassified_Indotyphlops : Indotyphlops, Iunclassified_Indotyphlops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Indotyphlops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630448;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Indotyphlops";
}
