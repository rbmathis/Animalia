using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Scapteromys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Scapteromys.unclassified_Scapteromys;

/// <summary>
/// Abstract class for unclassified Scapteromys (no rank).
/// NCBI TaxId: 2641614
/// </summary>
public abstract class unclassified_Scapteromys : Scapteromys, Iunclassified_Scapteromys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scapteromys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641614;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scapteromys";
}
