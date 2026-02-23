using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Microcambeva;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Microcambeva.unclassified_Microcambeva;

/// <summary>
/// Abstract class for unclassified Microcambeva (no rank).
/// NCBI TaxId: 2696886
/// </summary>
public abstract class unclassified_Microcambeva : Microcambeva, Iunclassified_Microcambeva
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Microcambeva";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2696886;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Microcambeva";
}
