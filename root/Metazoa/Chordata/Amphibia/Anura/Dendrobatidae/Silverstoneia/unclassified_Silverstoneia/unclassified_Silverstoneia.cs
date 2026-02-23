using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Silverstoneia;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Silverstoneia.unclassified_Silverstoneia;

/// <summary>
/// Abstract class for unclassified Silverstoneia (no rank).
/// NCBI TaxId: 2637584
/// </summary>
public abstract class unclassified_Silverstoneia : Silverstoneia, Iunclassified_Silverstoneia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Silverstoneia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637584;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Silverstoneia";
}
