using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Carlia;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Carlia.unclassified_Carlia;

/// <summary>
/// Abstract class for unclassified Carlia (no rank).
/// NCBI TaxId: 2685841
/// </summary>
public abstract class unclassified_Carlia : Carlia, Iunclassified_Carlia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Carlia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685841;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Carlia";
}
