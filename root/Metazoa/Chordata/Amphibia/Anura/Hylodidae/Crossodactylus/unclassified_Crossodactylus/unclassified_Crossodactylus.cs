using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylodidae.Crossodactylus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylodidae.Crossodactylus.unclassified_Crossodactylus;

/// <summary>
/// Abstract class for unclassified Crossodactylus (no rank).
/// NCBI TaxId: 2888484
/// </summary>
public abstract class unclassified_Crossodactylus : Crossodactylus, Iunclassified_Crossodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Crossodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2888484;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Crossodactylus";
}
