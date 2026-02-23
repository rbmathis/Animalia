using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Nannosalarias;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Nannosalarias.unclassified_Nannosalarias;

/// <summary>
/// Abstract class for unclassified Nannosalarias (no rank).
/// NCBI TaxId: 3397014
/// </summary>
public abstract class unclassified_Nannosalarias : Nannosalarias, Iunclassified_Nannosalarias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nannosalarias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3397014;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nannosalarias";
}
