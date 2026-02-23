using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Nannobrachium;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Nannobrachium.unclassified_Nannobrachium;

/// <summary>
/// Abstract class for unclassified Nannobrachium (no rank).
/// NCBI TaxId: 2981753
/// </summary>
public abstract class unclassified_Nannobrachium : Nannobrachium, Iunclassified_Nannobrachium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nannobrachium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2981753;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nannobrachium";
}
