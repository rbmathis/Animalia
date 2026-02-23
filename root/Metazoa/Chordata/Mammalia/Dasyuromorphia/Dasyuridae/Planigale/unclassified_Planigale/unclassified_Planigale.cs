using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Dasyuridae.Planigale;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Dasyuridae.Planigale.unclassified_Planigale;

/// <summary>
/// Abstract class for unclassified Planigale (no rank).
/// NCBI TaxId: 2626615
/// </summary>
public abstract class unclassified_Planigale : Planigale, Iunclassified_Planigale
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Planigale";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626615;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Planigale";
}
