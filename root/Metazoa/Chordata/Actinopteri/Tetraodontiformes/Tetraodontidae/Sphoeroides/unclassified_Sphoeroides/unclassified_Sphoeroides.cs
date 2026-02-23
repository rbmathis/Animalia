using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Sphoeroides;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Sphoeroides.unclassified_Sphoeroides;

/// <summary>
/// Abstract class for unclassified Sphoeroides (no rank).
/// NCBI TaxId: 2637934
/// </summary>
public abstract class unclassified_Sphoeroides : Sphoeroides, Iunclassified_Sphoeroides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sphoeroides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637934;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sphoeroides";
}
