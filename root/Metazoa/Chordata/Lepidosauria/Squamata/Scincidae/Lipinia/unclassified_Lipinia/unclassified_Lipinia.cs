using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Lipinia;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Lipinia.unclassified_Lipinia;

/// <summary>
/// Abstract class for unclassified Lipinia (no rank).
/// NCBI TaxId: 2623665
/// </summary>
public abstract class unclassified_Lipinia : Lipinia, Iunclassified_Lipinia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lipinia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623665;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lipinia";
}
