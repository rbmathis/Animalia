using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Hemiphyllodactylus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Hemiphyllodactylus.unclassified_Hemiphyllodactylus;

/// <summary>
/// Abstract class for unclassified Hemiphyllodactylus (no rank).
/// NCBI TaxId: 2627072
/// </summary>
public abstract class unclassified_Hemiphyllodactylus : Hemiphyllodactylus, Iunclassified_Hemiphyllodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hemiphyllodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627072;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hemiphyllodactylus";
}
