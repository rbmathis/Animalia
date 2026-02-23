using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Choeroichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Choeroichthys.unclassified_Choeroichthys;

/// <summary>
/// Abstract class for unclassified Choeroichthys (no rank).
/// NCBI TaxId: 2619161
/// </summary>
public abstract class unclassified_Choeroichthys : Choeroichthys, Iunclassified_Choeroichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Choeroichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619161;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Choeroichthys";
}
