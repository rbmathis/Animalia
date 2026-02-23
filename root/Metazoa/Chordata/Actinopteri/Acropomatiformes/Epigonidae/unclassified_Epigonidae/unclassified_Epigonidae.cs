using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Epigonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Epigonidae.unclassified_Epigonidae;

/// <summary>
/// Abstract class for unclassified Epigonidae (no rank).
/// NCBI TaxId: 2890362
/// </summary>
public abstract class unclassified_Epigonidae : Epigonidae, Iunclassified_Epigonidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Epigonidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2890362;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Epigonidae";
}
