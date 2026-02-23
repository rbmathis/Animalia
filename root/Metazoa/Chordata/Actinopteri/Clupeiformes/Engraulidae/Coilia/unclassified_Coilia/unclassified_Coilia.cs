using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae.Coilia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae.Coilia.unclassified_Coilia;

/// <summary>
/// Abstract class for unclassified Coilia (no rank).
/// NCBI TaxId: 2629198
/// </summary>
public abstract class unclassified_Coilia : Coilia, Iunclassified_Coilia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Coilia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629198;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Coilia";
}
