using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Crenadactylus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Crenadactylus.unclassified_Crenadactylus;

/// <summary>
/// Abstract class for unclassified Crenadactylus (no rank).
/// NCBI TaxId: 2628278
/// </summary>
public abstract class unclassified_Crenadactylus : Crenadactylus, Iunclassified_Crenadactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Crenadactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628278;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Crenadactylus";
}
