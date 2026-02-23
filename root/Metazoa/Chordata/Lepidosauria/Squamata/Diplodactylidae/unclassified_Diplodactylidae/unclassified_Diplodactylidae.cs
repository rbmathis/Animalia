using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.unclassified_Diplodactylidae;

/// <summary>
/// Abstract class for unclassified Diplodactylidae (no rank).
/// NCBI TaxId: 3055802
/// </summary>
public abstract class unclassified_Diplodactylidae : Diplodactylidae, Iunclassified_Diplodactylidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Diplodactylidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3055802;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Diplodactylidae";
}
