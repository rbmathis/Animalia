using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Cracidae.Pauxi;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Cracidae.Pauxi.unclassified_Pauxi;

/// <summary>
/// Abstract class for unclassified Pauxi (no rank).
/// NCBI TaxId: 2866052
/// </summary>
public abstract class unclassified_Pauxi : Pauxi, Iunclassified_Pauxi
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pauxi";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2866052;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pauxi";
}
