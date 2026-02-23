using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae.Leptobrachella;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae.Leptobrachella.unclassified_Leptobrachella;

/// <summary>
/// Abstract class for unclassified Leptobrachella (no rank).
/// NCBI TaxId: 2629684
/// </summary>
public abstract class unclassified_Leptobrachella : Leptobrachella, Iunclassified_Leptobrachella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Leptobrachella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629684;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Leptobrachella";
}
