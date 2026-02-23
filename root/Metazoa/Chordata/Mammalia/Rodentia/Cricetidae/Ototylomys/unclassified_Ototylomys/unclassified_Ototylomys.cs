using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Ototylomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Ototylomys.unclassified_Ototylomys;

/// <summary>
/// Abstract class for unclassified Ototylomys (no rank).
/// NCBI TaxId: 2646496
/// </summary>
public abstract class unclassified_Ototylomys : Ototylomys, Iunclassified_Ototylomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ototylomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646496;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ototylomys";
}
