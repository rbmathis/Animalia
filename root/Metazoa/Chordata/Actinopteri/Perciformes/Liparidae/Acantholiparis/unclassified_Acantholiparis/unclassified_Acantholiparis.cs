using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.Acantholiparis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.Acantholiparis.unclassified_Acantholiparis;

/// <summary>
/// Abstract class for unclassified Acantholiparis (no rank).
/// NCBI TaxId: 2684436
/// </summary>
public abstract class unclassified_Acantholiparis : Acantholiparis, Iunclassified_Acantholiparis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Acantholiparis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2684436;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Acantholiparis";
}
