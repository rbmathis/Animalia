using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae.unclassified_Batrachoididae;

/// <summary>
/// Abstract class for unclassified Batrachoididae (no rank).
/// NCBI TaxId: 1133086
/// </summary>
public abstract class unclassified_Batrachoididae : Batrachoididae, Iunclassified_Batrachoididae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Batrachoididae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1133086;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Batrachoididae";
}
