using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Ambystomatidae.Ambystoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Ambystomatidae.Ambystoma.unclassified_Ambystoma;

/// <summary>
/// Abstract class for unclassified Ambystoma (no rank).
/// NCBI TaxId: 2638523
/// </summary>
public abstract class unclassified_Ambystoma : Ambystoma, Iunclassified_Ambystoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ambystoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638523;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ambystoma";
}
