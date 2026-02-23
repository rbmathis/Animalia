using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Lile;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Lile.unclassified_Lile;

/// <summary>
/// Abstract class for unclassified Lile (no rank).
/// NCBI TaxId: 2631978
/// </summary>
public abstract class unclassified_Lile : Lile, Iunclassified_Lile
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lile";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631978;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lile";
}
