using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.unclassified_Liparidae;

/// <summary>
/// Abstract class for unclassified Liparidae (no rank).
/// NCBI TaxId: 1154622
/// </summary>
public abstract class unclassified_Liparidae : Liparidae, Iunclassified_Liparidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Liparidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1154622;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Liparidae";
}
