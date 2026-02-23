using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Fowleria;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Fowleria.unclassified_Fowleria;

/// <summary>
/// Abstract class for unclassified Fowleria (no rank).
/// NCBI TaxId: 2629122
/// </summary>
public abstract class unclassified_Fowleria : Fowleria, Iunclassified_Fowleria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Fowleria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629122;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Fowleria";
}
