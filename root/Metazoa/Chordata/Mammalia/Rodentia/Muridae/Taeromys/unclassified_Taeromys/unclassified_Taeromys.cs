using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Taeromys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Taeromys.unclassified_Taeromys;

/// <summary>
/// Abstract class for unclassified Taeromys (no rank).
/// NCBI TaxId: 2716779
/// </summary>
public abstract class unclassified_Taeromys : Taeromys, Iunclassified_Taeromys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Taeromys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2716779;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Taeromys";
}
