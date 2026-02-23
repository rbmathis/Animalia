using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Xenodermatidae.Achalinus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Xenodermatidae.Achalinus.unclassified_Achalinus;

/// <summary>
/// Abstract class for unclassified Achalinus (no rank).
/// NCBI TaxId: 2684978
/// </summary>
public abstract class unclassified_Achalinus : Achalinus, Iunclassified_Achalinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Achalinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2684978;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Achalinus";
}
