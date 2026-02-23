using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Chirocentridae.Chirocentrus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Chirocentridae.Chirocentrus.unclassified_Chirocentrus;

/// <summary>
/// Abstract class for unclassified Chirocentrus (no rank).
/// NCBI TaxId: 2629455
/// </summary>
public abstract class unclassified_Chirocentrus : Chirocentrus, Iunclassified_Chirocentrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chirocentrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629455;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chirocentrus";
}
