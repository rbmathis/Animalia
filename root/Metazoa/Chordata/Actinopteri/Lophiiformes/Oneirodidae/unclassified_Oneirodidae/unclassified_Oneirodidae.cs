using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Oneirodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Oneirodidae.unclassified_Oneirodidae;

/// <summary>
/// Abstract class for unclassified Oneirodidae (no rank).
/// NCBI TaxId: 2581911
/// </summary>
public abstract class unclassified_Oneirodidae : Oneirodidae, Iunclassified_Oneirodidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Oneirodidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2581911;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Oneirodidae";
}
