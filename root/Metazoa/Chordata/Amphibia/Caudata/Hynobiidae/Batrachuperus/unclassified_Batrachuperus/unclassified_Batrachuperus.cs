using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Hynobiidae.Batrachuperus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Hynobiidae.Batrachuperus.unclassified_Batrachuperus;

/// <summary>
/// Abstract class for unclassified Batrachuperus (no rank).
/// NCBI TaxId: 2685338
/// </summary>
public abstract class unclassified_Batrachuperus : Batrachuperus, Iunclassified_Batrachuperus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Batrachuperus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685338;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Batrachuperus";
}
