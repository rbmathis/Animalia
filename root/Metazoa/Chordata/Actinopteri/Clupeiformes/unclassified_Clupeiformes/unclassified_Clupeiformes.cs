using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.unclassified_Clupeiformes;

/// <summary>
/// Abstract class for unclassified Clupeiformes (no rank).
/// NCBI TaxId: 725795
/// </summary>
public abstract class unclassified_Clupeiformes : Clupeiformes, Iunclassified_Clupeiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Clupeiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 725795;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Clupeiformes";
}
