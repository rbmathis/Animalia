using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae.Madatyphlops;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae.Madatyphlops.unclassified_Madatyphlops;

/// <summary>
/// Abstract class for unclassified Madatyphlops (no rank).
/// NCBI TaxId: 2648624
/// </summary>
public abstract class unclassified_Madatyphlops : Madatyphlops, Iunclassified_Madatyphlops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Madatyphlops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648624;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Madatyphlops";
}
