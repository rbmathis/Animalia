using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.unclassified_Cheirodontinae;

/// <summary>
/// Abstract class for unclassified Cheirodontinae (no rank).
/// NCBI TaxId: 935220
/// </summary>
public abstract class unclassified_Cheirodontinae : Characidae, Iunclassified_Cheirodontinae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cheirodontinae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 935220;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cheirodontinae";
}
