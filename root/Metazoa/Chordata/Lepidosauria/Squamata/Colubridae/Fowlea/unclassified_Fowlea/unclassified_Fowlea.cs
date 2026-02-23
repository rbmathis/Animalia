using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Fowlea;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Fowlea.unclassified_Fowlea;

/// <summary>
/// Abstract class for unclassified Fowlea (no rank).
/// NCBI TaxId: 2879136
/// </summary>
public abstract class unclassified_Fowlea : Fowlea, Iunclassified_Fowlea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Fowlea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2879136;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Fowlea";
}
