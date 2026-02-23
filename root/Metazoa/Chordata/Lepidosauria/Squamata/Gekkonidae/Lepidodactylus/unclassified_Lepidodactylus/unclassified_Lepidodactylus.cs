using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Lepidodactylus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Lepidodactylus.unclassified_Lepidodactylus;

/// <summary>
/// Abstract class for unclassified Lepidodactylus (no rank).
/// NCBI TaxId: 2631596
/// </summary>
public abstract class unclassified_Lepidodactylus : Lepidodactylus, Iunclassified_Lepidodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lepidodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631596;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lepidodactylus";
}
