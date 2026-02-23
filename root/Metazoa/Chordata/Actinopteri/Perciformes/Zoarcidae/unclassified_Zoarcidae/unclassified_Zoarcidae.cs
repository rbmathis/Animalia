using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.unclassified_Zoarcidae;

/// <summary>
/// Abstract class for unclassified Zoarcidae (no rank).
/// NCBI TaxId: 947869
/// </summary>
public abstract class unclassified_Zoarcidae : Zoarcidae, Iunclassified_Zoarcidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Zoarcidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 947869;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Zoarcidae";
}
