using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Amalosia;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Amalosia.unclassified_Amalosia;

/// <summary>
/// Abstract class for unclassified Amalosia (no rank).
/// NCBI TaxId: 3115411
/// </summary>
public abstract class unclassified_Amalosia : Amalosia, Iunclassified_Amalosia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Amalosia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3115411;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Amalosia";
}
