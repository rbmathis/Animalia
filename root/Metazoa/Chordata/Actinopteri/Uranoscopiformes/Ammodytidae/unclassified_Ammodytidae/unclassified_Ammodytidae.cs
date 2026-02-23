using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Ammodytidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Ammodytidae.unclassified_Ammodytidae;

/// <summary>
/// Abstract class for unclassified Ammodytidae (no rank).
/// NCBI TaxId: 1781076
/// </summary>
public abstract class unclassified_Ammodytidae : Ammodytidae, Iunclassified_Ammodytidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ammodytidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1781076;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ammodytidae";
}
