using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Borikenophis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Borikenophis.unclassified_Borikenophis;

/// <summary>
/// Abstract class for unclassified Borikenophis (no rank).
/// NCBI TaxId: 2646574
/// </summary>
public abstract class unclassified_Borikenophis : Borikenophis, Iunclassified_Borikenophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Borikenophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646574;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Borikenophis";
}
