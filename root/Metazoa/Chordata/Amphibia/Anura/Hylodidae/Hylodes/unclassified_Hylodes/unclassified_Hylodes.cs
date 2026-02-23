using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylodidae.Hylodes;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylodidae.Hylodes.unclassified_Hylodes;

/// <summary>
/// Abstract class for unclassified Hylodes (no rank).
/// NCBI TaxId: 2765883
/// </summary>
public abstract class unclassified_Hylodes : Hylodes, Iunclassified_Hylodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hylodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2765883;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hylodes";
}
