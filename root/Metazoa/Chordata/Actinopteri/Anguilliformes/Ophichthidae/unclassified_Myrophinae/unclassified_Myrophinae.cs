using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.unclassified_Myrophinae;

/// <summary>
/// Abstract class for unclassified Myrophinae (no rank).
/// NCBI TaxId: 267673
/// </summary>
public abstract class unclassified_Myrophinae : Ophichthidae, Iunclassified_Myrophinae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Myrophinae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 267673;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Myrophinae";
}
