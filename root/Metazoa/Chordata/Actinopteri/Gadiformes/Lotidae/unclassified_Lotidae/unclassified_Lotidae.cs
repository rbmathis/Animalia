using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Lotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Lotidae.unclassified_Lotidae;

/// <summary>
/// Abstract class for unclassified Lotidae (no rank).
/// NCBI TaxId: 1181455
/// </summary>
public abstract class unclassified_Lotidae : Lotidae, Iunclassified_Lotidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lotidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1181455;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lotidae";
}
