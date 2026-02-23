using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Thomasomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Thomasomys.unclassified_Thomasomys;

/// <summary>
/// Abstract class for unclassified Thomasomys (no rank).
/// NCBI TaxId: 2626964
/// </summary>
public abstract class unclassified_Thomasomys : Thomasomys, Iunclassified_Thomasomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Thomasomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626964;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Thomasomys";
}
