using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.Rhinoliparis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.Rhinoliparis.unclassified_Rhinoliparis;

/// <summary>
/// Abstract class for unclassified Rhinoliparis (no rank).
/// NCBI TaxId: 2629400
/// </summary>
public abstract class unclassified_Rhinoliparis : Rhinoliparis, Iunclassified_Rhinoliparis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhinoliparis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629400;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhinoliparis";
}
