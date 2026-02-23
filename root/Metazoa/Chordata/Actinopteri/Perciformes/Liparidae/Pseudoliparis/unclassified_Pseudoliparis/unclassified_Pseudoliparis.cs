using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.Pseudoliparis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.Pseudoliparis.unclassified_Pseudoliparis;

/// <summary>
/// Abstract class for unclassified Pseudoliparis (no rank).
/// NCBI TaxId: 2639990
/// </summary>
public abstract class unclassified_Pseudoliparis : Pseudoliparis, Iunclassified_Pseudoliparis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudoliparis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639990;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudoliparis";
}
