using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Neotomodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Neotomodon.unclassified_Neotomodon;

/// <summary>
/// Abstract class for unclassified Neotomodon (no rank).
/// NCBI TaxId: 2633470
/// </summary>
public abstract class unclassified_Neotomodon : Neotomodon, Iunclassified_Neotomodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Neotomodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633470;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Neotomodon";
}
