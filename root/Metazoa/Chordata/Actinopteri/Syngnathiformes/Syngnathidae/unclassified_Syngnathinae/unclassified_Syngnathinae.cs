using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.unclassified_Syngnathinae;

/// <summary>
/// Abstract class for unclassified Syngnathinae (no rank).
/// NCBI TaxId: 1100849
/// </summary>
public abstract class unclassified_Syngnathinae : Syngnathidae, Iunclassified_Syngnathinae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Syngnathinae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1100849;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Syngnathinae";
}
