using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Copeoglossum;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Copeoglossum.unclassified_Copeoglossum;

/// <summary>
/// Abstract class for unclassified Copeoglossum (no rank).
/// NCBI TaxId: 3108812
/// </summary>
public abstract class unclassified_Copeoglossum : Copeoglossum, Iunclassified_Copeoglossum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Copeoglossum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3108812;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Copeoglossum";
}
