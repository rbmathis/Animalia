using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Nectomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Nectomys.unclassified_Nectomys;

/// <summary>
/// Abstract class for unclassified Nectomys (no rank).
/// NCBI TaxId: 2632481
/// </summary>
public abstract class unclassified_Nectomys : Nectomys, Iunclassified_Nectomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nectomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632481;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nectomys";
}
