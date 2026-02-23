using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Diplodactylus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Diplodactylus.unclassified_Diplodactylus;

/// <summary>
/// Abstract class for unclassified Diplodactylus (no rank).
/// NCBI TaxId: 2644238
/// </summary>
public abstract class unclassified_Diplodactylus : Diplodactylus, Iunclassified_Diplodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Diplodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644238;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Diplodactylus";
}
