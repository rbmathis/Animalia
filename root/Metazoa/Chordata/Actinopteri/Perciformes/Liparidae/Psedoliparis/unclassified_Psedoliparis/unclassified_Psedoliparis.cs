using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.Psedoliparis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.Psedoliparis.unclassified_Psedoliparis;

/// <summary>
/// Abstract class for unclassified Psedoliparis (no rank).
/// NCBI TaxId: 2936622
/// </summary>
public abstract class unclassified_Psedoliparis : Psedoliparis, Iunclassified_Psedoliparis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Psedoliparis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2936622;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Psedoliparis";
}
