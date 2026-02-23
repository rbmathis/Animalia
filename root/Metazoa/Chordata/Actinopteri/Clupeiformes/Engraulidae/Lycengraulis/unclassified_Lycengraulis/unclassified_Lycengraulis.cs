using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae.Lycengraulis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae.Lycengraulis.unclassified_Lycengraulis;

/// <summary>
/// Abstract class for unclassified Lycengraulis (no rank).
/// NCBI TaxId: 3049102
/// </summary>
public abstract class unclassified_Lycengraulis : Lycengraulis, Iunclassified_Lycengraulis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lycengraulis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3049102;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lycengraulis";
}
