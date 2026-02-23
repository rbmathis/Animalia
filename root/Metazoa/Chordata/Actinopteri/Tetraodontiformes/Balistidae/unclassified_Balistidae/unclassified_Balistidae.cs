using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Balistidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Balistidae.unclassified_Balistidae;

/// <summary>
/// Abstract class for unclassified Balistidae (no rank).
/// NCBI TaxId: 188527
/// </summary>
public abstract class unclassified_Balistidae : Balistidae, Iunclassified_Balistidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Balistidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 188527;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Balistidae";
}
