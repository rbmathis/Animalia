using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Crossodactylodes;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Crossodactylodes.unclassified_Crossodactylodes;

/// <summary>
/// Abstract class for unclassified Crossodactylodes (no rank).
/// NCBI TaxId: 2730597
/// </summary>
public abstract class unclassified_Crossodactylodes : Crossodactylodes, Iunclassified_Crossodactylodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Crossodactylodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2730597;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Crossodactylodes";
}
