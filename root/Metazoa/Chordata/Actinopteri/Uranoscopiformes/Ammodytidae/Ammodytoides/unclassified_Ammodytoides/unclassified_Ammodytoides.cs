using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Ammodytidae.Ammodytoides;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Ammodytidae.Ammodytoides.unclassified_Ammodytoides;

/// <summary>
/// Abstract class for unclassified Ammodytoides (no rank).
/// NCBI TaxId: 2634071
/// </summary>
public abstract class unclassified_Ammodytoides : Ammodytoides, Iunclassified_Ammodytoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ammodytoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634071;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ammodytoides";
}
