using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Cyrtodactylus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Cyrtodactylus.unclassified_Cyrtodactylus;

/// <summary>
/// Abstract class for unclassified Cyrtodactylus (no rank).
/// NCBI TaxId: 1266627
/// </summary>
public abstract class unclassified_Cyrtodactylus : Cyrtodactylus, Iunclassified_Cyrtodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cyrtodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1266627;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cyrtodactylus";
}
