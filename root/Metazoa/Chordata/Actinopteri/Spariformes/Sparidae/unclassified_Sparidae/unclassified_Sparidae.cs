using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.unclassified_Sparidae;

/// <summary>
/// Abstract class for unclassified Sparidae (no rank).
/// NCBI TaxId: 1678903
/// </summary>
public abstract class unclassified_Sparidae : Sparidae, Iunclassified_Sparidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sparidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1678903;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sparidae";
}
