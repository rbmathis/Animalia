using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae.Chamaeleo;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae.Chamaeleo.unclassified_Chamaeleo;

/// <summary>
/// Abstract class for unclassified Chamaeleo (no rank).
/// NCBI TaxId: 2618438
/// </summary>
public abstract class unclassified_Chamaeleo : Chamaeleo, Iunclassified_Chamaeleo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chamaeleo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618438;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chamaeleo";
}
