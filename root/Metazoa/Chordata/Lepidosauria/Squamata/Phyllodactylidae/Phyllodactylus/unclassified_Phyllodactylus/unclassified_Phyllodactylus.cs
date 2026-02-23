using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phyllodactylidae.Phyllodactylus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phyllodactylidae.Phyllodactylus.unclassified_Phyllodactylus;

/// <summary>
/// Abstract class for unclassified Phyllodactylus (no rank).
/// NCBI TaxId: 2634174
/// </summary>
public abstract class unclassified_Phyllodactylus : Phyllodactylus, Iunclassified_Phyllodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phyllodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634174;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phyllodactylus";
}
