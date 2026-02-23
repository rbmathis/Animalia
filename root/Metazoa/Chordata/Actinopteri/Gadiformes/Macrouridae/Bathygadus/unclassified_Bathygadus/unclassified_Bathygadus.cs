using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Bathygadus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Bathygadus.unclassified_Bathygadus;

/// <summary>
/// Abstract class for unclassified Bathygadus (no rank).
/// NCBI TaxId: 2649922
/// </summary>
public abstract class unclassified_Bathygadus : Bathygadus, Iunclassified_Bathygadus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bathygadus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649922;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bathygadus";
}
