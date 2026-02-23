using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae.Occidozyga;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae.Occidozyga.unclassified_Occidozyga;

/// <summary>
/// Abstract class for unclassified Occidozyga (no rank).
/// NCBI TaxId: 2638306
/// </summary>
public abstract class unclassified_Occidozyga : Occidozyga, Iunclassified_Occidozyga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Occidozyga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638306;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Occidozyga";
}
