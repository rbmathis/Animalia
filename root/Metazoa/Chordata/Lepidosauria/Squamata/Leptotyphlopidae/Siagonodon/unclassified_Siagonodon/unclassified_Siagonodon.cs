using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leptotyphlopidae.Siagonodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leptotyphlopidae.Siagonodon.unclassified_Siagonodon;

/// <summary>
/// Abstract class for unclassified Siagonodon (no rank).
/// NCBI TaxId: 2638386
/// </summary>
public abstract class unclassified_Siagonodon : Siagonodon, Iunclassified_Siagonodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Siagonodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638386;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Siagonodon";
}
