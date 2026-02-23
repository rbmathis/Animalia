using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.unclassified_Leuciscidae;

/// <summary>
/// Abstract class for unclassified Leuciscidae (no rank).
/// NCBI TaxId: 2905710
/// </summary>
public abstract class unclassified_Leuciscidae : Leuciscidae, Iunclassified_Leuciscidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Leuciscidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2905710;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Leuciscidae";
}
