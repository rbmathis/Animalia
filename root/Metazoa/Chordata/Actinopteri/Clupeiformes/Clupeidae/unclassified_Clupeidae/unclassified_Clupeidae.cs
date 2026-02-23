using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.unclassified_Clupeidae;

/// <summary>
/// Abstract class for unclassified Clupeidae (no rank).
/// NCBI TaxId: 249029
/// </summary>
public abstract class unclassified_Clupeidae : Clupeidae, Iunclassified_Clupeidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Clupeidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 249029;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Clupeidae";
}
