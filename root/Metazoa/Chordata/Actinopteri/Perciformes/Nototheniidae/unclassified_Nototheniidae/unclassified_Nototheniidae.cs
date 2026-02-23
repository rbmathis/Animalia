using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Nototheniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Nototheniidae.unclassified_Nototheniidae;

/// <summary>
/// Abstract class for unclassified Nototheniidae (no rank).
/// NCBI TaxId: 368775
/// </summary>
public abstract class unclassified_Nototheniidae : Nototheniidae, Iunclassified_Nototheniidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nototheniidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 368775;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nototheniidae";
}
