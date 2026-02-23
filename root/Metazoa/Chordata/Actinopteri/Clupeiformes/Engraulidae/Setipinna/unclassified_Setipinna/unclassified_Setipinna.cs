using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae.Setipinna;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae.Setipinna.unclassified_Setipinna;

/// <summary>
/// Abstract class for unclassified Setipinna (no rank).
/// NCBI TaxId: 2630157
/// </summary>
public abstract class unclassified_Setipinna : Setipinna, Iunclassified_Setipinna
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Setipinna";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630157;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Setipinna";
}
