using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae.unclassified_Monacanthidae;

/// <summary>
/// Abstract class for unclassified Monacanthidae (no rank).
/// NCBI TaxId: 1182089
/// </summary>
public abstract class unclassified_Monacanthidae : Monacanthidae, Iunclassified_Monacanthidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Monacanthidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1182089;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Monacanthidae";
}
