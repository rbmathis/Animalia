using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Rhagomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Rhagomys.unclassified_Rhagomys;

/// <summary>
/// Abstract class for unclassified Rhagomys (no rank).
/// NCBI TaxId: 2782732
/// </summary>
public abstract class unclassified_Rhagomys : Rhagomys, Iunclassified_Rhagomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhagomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2782732;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhagomys";
}
