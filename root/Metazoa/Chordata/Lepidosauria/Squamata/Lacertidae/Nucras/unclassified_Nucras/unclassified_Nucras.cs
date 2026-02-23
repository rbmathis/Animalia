using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Nucras;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Nucras.unclassified_Nucras;

/// <summary>
/// Abstract class for unclassified Nucras (no rank).
/// NCBI TaxId: 2620973
/// </summary>
public abstract class unclassified_Nucras : Nucras, Iunclassified_Nucras
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nucras";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620973;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nucras";
}
