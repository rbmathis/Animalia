using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Micropechis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Micropechis.unclassified_Micropechis;

/// <summary>
/// Abstract class for unclassified Micropechis (no rank).
/// NCBI TaxId: 2837581
/// </summary>
public abstract class unclassified_Micropechis : Micropechis, Iunclassified_Micropechis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Micropechis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2837581;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Micropechis";
}
