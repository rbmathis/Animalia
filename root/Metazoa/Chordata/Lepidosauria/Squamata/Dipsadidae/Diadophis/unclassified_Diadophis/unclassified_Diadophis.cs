using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Diadophis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Diadophis.unclassified_Diadophis;

/// <summary>
/// Abstract class for unclassified Diadophis (no rank).
/// NCBI TaxId: 2878424
/// </summary>
public abstract class unclassified_Diadophis : Diadophis, Iunclassified_Diadophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Diadophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2878424;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Diadophis";
}
