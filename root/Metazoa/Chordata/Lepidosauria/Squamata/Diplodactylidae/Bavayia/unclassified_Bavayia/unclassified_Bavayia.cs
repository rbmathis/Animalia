using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Bavayia;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Bavayia.unclassified_Bavayia;

/// <summary>
/// Abstract class for unclassified Bavayia (no rank).
/// NCBI TaxId: 2623266
/// </summary>
public abstract class unclassified_Bavayia : Bavayia, Iunclassified_Bavayia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bavayia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623266;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bavayia";
}
