using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Tachymenoides;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Tachymenoides.unclassified_Tachymenoides;

/// <summary>
/// Abstract class for unclassified Tachymenoides (no rank).
/// NCBI TaxId: 3043596
/// </summary>
public abstract class unclassified_Tachymenoides : Tachymenoides, Iunclassified_Tachymenoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tachymenoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3043596;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tachymenoides";
}
