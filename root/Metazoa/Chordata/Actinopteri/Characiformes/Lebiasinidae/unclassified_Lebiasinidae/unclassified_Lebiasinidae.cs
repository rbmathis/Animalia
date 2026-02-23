using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Lebiasinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Lebiasinidae.unclassified_Lebiasinidae;

/// <summary>
/// Abstract class for unclassified Lebiasinidae (no rank).
/// NCBI TaxId: 909888
/// </summary>
public abstract class unclassified_Lebiasinidae : Lebiasinidae, Iunclassified_Lebiasinidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lebiasinidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 909888;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lebiasinidae";
}
