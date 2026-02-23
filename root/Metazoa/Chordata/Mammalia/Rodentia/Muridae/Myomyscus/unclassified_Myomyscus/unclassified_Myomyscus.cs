using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Myomyscus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Myomyscus.unclassified_Myomyscus;

/// <summary>
/// Abstract class for unclassified Myomyscus (no rank).
/// NCBI TaxId: 2622693
/// </summary>
public abstract class unclassified_Myomyscus : Myomyscus, Iunclassified_Myomyscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Myomyscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622693;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Myomyscus";
}
