using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae.Pervagor;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae.Pervagor.unclassified_Pervagor;

/// <summary>
/// Abstract class for unclassified Pervagor (no rank).
/// NCBI TaxId: 2619894
/// </summary>
public abstract class unclassified_Pervagor : Pervagor, Iunclassified_Pervagor
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pervagor";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619894;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pervagor";
}
