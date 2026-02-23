using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Chibchanomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Chibchanomys.unclassified_Chibchanomys;

/// <summary>
/// Abstract class for unclassified Chibchanomys (no rank).
/// NCBI TaxId: 2928177
/// </summary>
public abstract class unclassified_Chibchanomys : Chibchanomys, Iunclassified_Chibchanomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chibchanomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2928177;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chibchanomys";
}
