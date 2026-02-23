using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Chirocentridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Chirocentridae.unclassified_Chirocentridae;

/// <summary>
/// Abstract class for unclassified Chirocentridae (no rank).
/// NCBI TaxId: 3444647
/// </summary>
public abstract class unclassified_Chirocentridae : Chirocentridae, Iunclassified_Chirocentridae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chirocentridae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3444647;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chirocentridae";
}
