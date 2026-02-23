using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Gigantactinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Gigantactinidae.unclassified_Gigantactinidae;

/// <summary>
/// Abstract class for unclassified Gigantactinidae (no rank).
/// NCBI TaxId: 885012
/// </summary>
public abstract class unclassified_Gigantactinidae : Gigantactinidae, Iunclassified_Gigantactinidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gigantactinidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 885012;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gigantactinidae";
}
