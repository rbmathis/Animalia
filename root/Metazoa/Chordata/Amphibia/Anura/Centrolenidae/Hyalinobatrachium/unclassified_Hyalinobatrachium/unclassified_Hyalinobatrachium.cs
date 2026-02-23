using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae.Hyalinobatrachium;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae.Hyalinobatrachium.unclassified_Hyalinobatrachium;

/// <summary>
/// Abstract class for unclassified Hyalinobatrachium (no rank).
/// NCBI TaxId: 2618021
/// </summary>
public abstract class unclassified_Hyalinobatrachium : Hyalinobatrachium, Iunclassified_Hyalinobatrachium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hyalinobatrachium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618021;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hyalinobatrachium";
}
