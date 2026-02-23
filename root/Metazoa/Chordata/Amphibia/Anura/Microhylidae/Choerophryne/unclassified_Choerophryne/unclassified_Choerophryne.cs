using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Choerophryne;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Choerophryne.unclassified_Choerophryne;

/// <summary>
/// Abstract class for unclassified Choerophryne (no rank).
/// NCBI TaxId: 2635356
/// </summary>
public abstract class unclassified_Choerophryne : Choerophryne, Iunclassified_Choerophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Choerophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635356;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Choerophryne";
}
