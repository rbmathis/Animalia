using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Wijayarana;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Wijayarana.unclassified_Wijayarana;

/// <summary>
/// Abstract class for unclassified Wijayarana (no rank).
/// NCBI TaxId: 2860738
/// </summary>
public abstract class unclassified_Wijayarana : Wijayarana, Iunclassified_Wijayarana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Wijayarana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2860738;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Wijayarana";
}
