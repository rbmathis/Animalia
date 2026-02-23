using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Xantusiidae.Lepidophyma;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Xantusiidae.Lepidophyma.unclassified_Lepidophyma;

/// <summary>
/// Abstract class for unclassified Lepidophyma (no rank).
/// NCBI TaxId: 2637389
/// </summary>
public abstract class unclassified_Lepidophyma : Lepidophyma, Iunclassified_Lepidophyma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lepidophyma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637389;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lepidophyma";
}
