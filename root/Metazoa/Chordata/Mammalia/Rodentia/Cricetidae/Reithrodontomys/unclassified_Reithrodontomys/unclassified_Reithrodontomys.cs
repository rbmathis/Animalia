using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Reithrodontomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Reithrodontomys.unclassified_Reithrodontomys;

/// <summary>
/// Abstract class for unclassified Reithrodontomys (no rank).
/// NCBI TaxId: 2635895
/// </summary>
public abstract class unclassified_Reithrodontomys : Reithrodontomys, Iunclassified_Reithrodontomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Reithrodontomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635895;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Reithrodontomys";
}
