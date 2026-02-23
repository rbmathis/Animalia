using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phyllodactylidae.Ptyodactylus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phyllodactylidae.Ptyodactylus.unclassified_Ptyodactylus;

/// <summary>
/// Abstract class for unclassified Ptyodactylus (no rank).
/// NCBI TaxId: 2974579
/// </summary>
public abstract class unclassified_Ptyodactylus : Ptyodactylus, Iunclassified_Ptyodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ptyodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2974579;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ptyodactylus";
}
