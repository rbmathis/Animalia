using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Lygodactylus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Lygodactylus.unclassified_Lygodactylus;

/// <summary>
/// Abstract class for unclassified Lygodactylus (no rank).
/// NCBI TaxId: 2646468
/// </summary>
public abstract class unclassified_Lygodactylus : Lygodactylus, Iunclassified_Lygodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lygodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646468;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lygodactylus";
}
