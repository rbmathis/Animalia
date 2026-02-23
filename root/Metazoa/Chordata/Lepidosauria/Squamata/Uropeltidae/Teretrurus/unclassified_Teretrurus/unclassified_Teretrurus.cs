using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Uropeltidae.Teretrurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Uropeltidae.Teretrurus.unclassified_Teretrurus;

/// <summary>
/// Abstract class for unclassified Teretrurus (no rank).
/// NCBI TaxId: 2631542
/// </summary>
public abstract class unclassified_Teretrurus : Teretrurus, Iunclassified_Teretrurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Teretrurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631542;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Teretrurus";
}
