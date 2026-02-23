using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Leptosiaphos;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Leptosiaphos.unclassified_Leptosiaphos;

/// <summary>
/// Abstract class for unclassified Leptosiaphos (no rank).
/// NCBI TaxId: 2618437
/// </summary>
public abstract class unclassified_Leptosiaphos : Leptosiaphos, Iunclassified_Leptosiaphos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Leptosiaphos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618437;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Leptosiaphos";
}
