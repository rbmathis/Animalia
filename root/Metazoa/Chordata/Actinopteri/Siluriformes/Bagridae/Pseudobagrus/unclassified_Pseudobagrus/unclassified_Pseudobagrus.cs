using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae.Pseudobagrus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae.Pseudobagrus.unclassified_Pseudobagrus;

/// <summary>
/// Abstract class for unclassified Pseudobagrus (no rank).
/// NCBI TaxId: 2640101
/// </summary>
public abstract class unclassified_Pseudobagrus : Pseudobagrus, Iunclassified_Pseudobagrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudobagrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640101;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudobagrus";
}
