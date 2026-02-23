using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Melanocetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Melanocetidae.unclassified_Melanocetidae;

/// <summary>
/// Abstract class for unclassified Melanocetidae (no rank).
/// NCBI TaxId: 3230572
/// </summary>
public abstract class unclassified_Melanocetidae : Melanocetidae, Iunclassified_Melanocetidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Melanocetidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3230572;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Melanocetidae";
}
