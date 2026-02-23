using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Choerodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Choerodon.unclassified_Choerodon;

/// <summary>
/// Abstract class for unclassified Choerodon (no rank).
/// NCBI TaxId: 2637095
/// </summary>
public abstract class unclassified_Choerodon : Choerodon, Iunclassified_Choerodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Choerodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637095;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Choerodon";
}
