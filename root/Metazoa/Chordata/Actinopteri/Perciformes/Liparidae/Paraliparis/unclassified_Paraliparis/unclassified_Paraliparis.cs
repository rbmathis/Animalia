using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.Paraliparis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.Paraliparis.unclassified_Paraliparis;

/// <summary>
/// Abstract class for unclassified Paraliparis (no rank).
/// NCBI TaxId: 2597799
/// </summary>
public abstract class unclassified_Paraliparis : Paraliparis, Iunclassified_Paraliparis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paraliparis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2597799;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paraliparis";
}
