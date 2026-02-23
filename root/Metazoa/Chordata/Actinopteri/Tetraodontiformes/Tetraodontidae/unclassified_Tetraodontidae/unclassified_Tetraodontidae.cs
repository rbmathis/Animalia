using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.unclassified_Tetraodontidae;

/// <summary>
/// Abstract class for unclassified Tetraodontidae (no rank).
/// NCBI TaxId: 1182134
/// </summary>
public abstract class unclassified_Tetraodontidae : Tetraodontidae, Iunclassified_Tetraodontidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tetraodontidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1182134;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tetraodontidae";
}
