using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.unclassified_Characidae;

/// <summary>
/// Abstract class for unclassified Characidae (no rank).
/// NCBI TaxId: 1158450
/// </summary>
public abstract class unclassified_Characidae : Characidae, Iunclassified_Characidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Characidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1158450;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Characidae";
}
