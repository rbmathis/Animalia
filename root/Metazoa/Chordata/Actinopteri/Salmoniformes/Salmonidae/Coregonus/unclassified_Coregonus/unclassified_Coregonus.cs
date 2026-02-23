using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Coregonus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Coregonus.unclassified_Coregonus;

/// <summary>
/// Abstract class for unclassified Coregonus (no rank).
/// NCBI TaxId: 2649731
/// </summary>
public abstract class unclassified_Coregonus : Coregonus, Iunclassified_Coregonus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Coregonus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649731;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Coregonus";
}
