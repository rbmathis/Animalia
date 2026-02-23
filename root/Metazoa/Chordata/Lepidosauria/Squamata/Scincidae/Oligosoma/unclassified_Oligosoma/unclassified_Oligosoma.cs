using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Oligosoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Oligosoma.unclassified_Oligosoma;

/// <summary>
/// Abstract class for unclassified Oligosoma (no rank).
/// NCBI TaxId: 2633069
/// </summary>
public abstract class unclassified_Oligosoma : Oligosoma, Iunclassified_Oligosoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Oligosoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633069;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Oligosoma";
}
