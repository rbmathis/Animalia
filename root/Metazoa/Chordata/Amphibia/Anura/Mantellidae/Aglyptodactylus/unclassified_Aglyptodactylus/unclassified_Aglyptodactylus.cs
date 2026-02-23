using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae.Aglyptodactylus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae.Aglyptodactylus.unclassified_Aglyptodactylus;

/// <summary>
/// Abstract class for unclassified Aglyptodactylus (no rank).
/// NCBI TaxId: 2632598
/// </summary>
public abstract class unclassified_Aglyptodactylus : Aglyptodactylus, Iunclassified_Aglyptodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aglyptodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632598;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aglyptodactylus";
}
