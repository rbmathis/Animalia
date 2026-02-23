using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae.Engraulis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae.Engraulis.unclassified_Engraulis;

/// <summary>
/// Abstract class for unclassified Engraulis (no rank).
/// NCBI TaxId: 2647398
/// </summary>
public abstract class unclassified_Engraulis : Engraulis, Iunclassified_Engraulis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Engraulis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647398;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Engraulis";
}
