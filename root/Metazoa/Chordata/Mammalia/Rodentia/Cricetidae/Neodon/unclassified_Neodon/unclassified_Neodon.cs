using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Neodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Neodon.unclassified_Neodon;

/// <summary>
/// Abstract class for unclassified Neodon (no rank).
/// NCBI TaxId: 2613862
/// </summary>
public abstract class unclassified_Neodon : Neodon, Iunclassified_Neodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Neodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2613862;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Neodon";
}
