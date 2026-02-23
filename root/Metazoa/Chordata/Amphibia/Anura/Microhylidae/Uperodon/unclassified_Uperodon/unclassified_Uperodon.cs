using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Uperodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Uperodon.unclassified_Uperodon;

/// <summary>
/// Abstract class for unclassified Uperodon (no rank).
/// NCBI TaxId: 2627658
/// </summary>
public abstract class unclassified_Uperodon : Uperodon, Iunclassified_Uperodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Uperodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627658;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Uperodon";
}
