using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Oryzomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Oryzomys.unclassified_Oryzomys;

/// <summary>
/// Abstract class for unclassified Oryzomys (no rank).
/// NCBI TaxId: 2635748
/// </summary>
public abstract class unclassified_Oryzomys : Oryzomys, Iunclassified_Oryzomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Oryzomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635748;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Oryzomys";
}
