using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phyllodactylidae.Phyllopezus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phyllodactylidae.Phyllopezus.unclassified_Phyllopezus;

/// <summary>
/// Abstract class for unclassified Phyllopezus (no rank).
/// NCBI TaxId: 2633867
/// </summary>
public abstract class unclassified_Phyllopezus : Phyllopezus, Iunclassified_Phyllopezus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phyllopezus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633867;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phyllopezus";
}
