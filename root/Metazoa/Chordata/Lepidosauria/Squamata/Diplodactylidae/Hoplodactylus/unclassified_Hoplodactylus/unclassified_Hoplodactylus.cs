using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Hoplodactylus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Hoplodactylus.unclassified_Hoplodactylus;

/// <summary>
/// Abstract class for unclassified Hoplodactylus (no rank).
/// NCBI TaxId: 2620006
/// </summary>
public abstract class unclassified_Hoplodactylus : Hoplodactylus, Iunclassified_Hoplodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hoplodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620006;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hoplodactylus";
}
