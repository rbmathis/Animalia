using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Microryzomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Microryzomys.unclassified_Microryzomys;

/// <summary>
/// Abstract class for unclassified Microryzomys (no rank).
/// NCBI TaxId: 3115255
/// </summary>
public abstract class unclassified_Microryzomys : Microryzomys, Iunclassified_Microryzomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Microryzomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3115255;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Microryzomys";
}
