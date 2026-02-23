using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.unclassified_Scincidae;

/// <summary>
/// Abstract class for unclassified Scincidae (no rank).
/// NCBI TaxId: 2590757
/// </summary>
public abstract class unclassified_Scincidae : Scincidae, Iunclassified_Scincidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scincidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2590757;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scincidae";
}
