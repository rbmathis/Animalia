using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae.Leptobrachium;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae.Leptobrachium.unclassified_Leptobrachium;

/// <summary>
/// Abstract class for unclassified Leptobrachium (no rank).
/// NCBI TaxId: 2641398
/// </summary>
public abstract class unclassified_Leptobrachium : Leptobrachium, Iunclassified_Leptobrachium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Leptobrachium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641398;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Leptobrachium";
}
