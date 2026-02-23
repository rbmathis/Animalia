using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.unclassified_Caudata;

/// <summary>
/// Abstract class for unclassified Caudata (no rank).
/// NCBI TaxId: 718304
/// </summary>
public abstract class unclassified_Caudata : Caudata, Iunclassified_Caudata
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Caudata";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 718304;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Caudata";
}
