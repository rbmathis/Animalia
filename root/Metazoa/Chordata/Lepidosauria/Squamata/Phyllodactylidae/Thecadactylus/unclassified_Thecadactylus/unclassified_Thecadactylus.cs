using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phyllodactylidae.Thecadactylus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phyllodactylidae.Thecadactylus.unclassified_Thecadactylus;

/// <summary>
/// Abstract class for unclassified Thecadactylus (no rank).
/// NCBI TaxId: 2637414
/// </summary>
public abstract class unclassified_Thecadactylus : Thecadactylus, Iunclassified_Thecadactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Thecadactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637414;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Thecadactylus";
}
