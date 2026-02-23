using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Trachyrhamphus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Trachyrhamphus.unclassified_Trachyrhamphus;

/// <summary>
/// Abstract class for unclassified Trachyrhamphus (no rank).
/// NCBI TaxId: 2630930
/// </summary>
public abstract class unclassified_Trachyrhamphus : Trachyrhamphus, Iunclassified_Trachyrhamphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Trachyrhamphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630930;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Trachyrhamphus";
}
