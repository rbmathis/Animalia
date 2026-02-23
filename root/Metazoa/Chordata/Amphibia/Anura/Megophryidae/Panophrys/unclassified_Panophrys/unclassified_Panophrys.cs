using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae.Panophrys;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae.Panophrys.unclassified_Panophrys;

/// <summary>
/// Abstract class for unclassified Panophrys (no rank).
/// NCBI TaxId: 2860056
/// </summary>
public abstract class unclassified_Panophrys : Panophrys, Iunclassified_Panophrys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Panophrys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2860056;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Panophrys";
}
