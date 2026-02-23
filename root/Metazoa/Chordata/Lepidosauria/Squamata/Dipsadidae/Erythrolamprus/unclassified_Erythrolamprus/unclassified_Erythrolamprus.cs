using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Erythrolamprus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Erythrolamprus.unclassified_Erythrolamprus;

/// <summary>
/// Abstract class for unclassified Erythrolamprus (no rank).
/// NCBI TaxId: 3467901
/// </summary>
public abstract class unclassified_Erythrolamprus : Erythrolamprus, Iunclassified_Erythrolamprus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Erythrolamprus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3467901;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Erythrolamprus";
}
