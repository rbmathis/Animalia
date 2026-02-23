using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.unclassified_Muridae;

/// <summary>
/// Abstract class for unclassified Muridae (no rank).
/// NCBI TaxId: 58328
/// </summary>
public abstract class unclassified_Muridae : Muridae, Iunclassified_Muridae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Muridae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 58328;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Muridae";
}
