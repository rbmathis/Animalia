using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Phymaturus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Phymaturus.unclassified_Phymaturus;

/// <summary>
/// Abstract class for unclassified Phymaturus (no rank).
/// NCBI TaxId: 1260075
/// </summary>
public abstract class unclassified_Phymaturus : Phymaturus, Iunclassified_Phymaturus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phymaturus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1260075;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phymaturus";
}
