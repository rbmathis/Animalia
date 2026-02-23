using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Notoungulata.Toxodontidae.Toxodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Notoungulata.Toxodontidae.Toxodon.unclassified_Toxodon;

/// <summary>
/// Abstract class for unclassified Toxodon (no rank).
/// NCBI TaxId: 2630100
/// </summary>
public abstract class unclassified_Toxodon : Toxodon, Iunclassified_Toxodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Toxodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630100;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Toxodon";
}
