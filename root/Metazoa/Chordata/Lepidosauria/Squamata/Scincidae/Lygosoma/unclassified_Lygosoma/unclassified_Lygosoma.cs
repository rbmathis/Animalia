using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Lygosoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Lygosoma.unclassified_Lygosoma;

/// <summary>
/// Abstract class for unclassified Lygosoma (no rank).
/// NCBI TaxId: 2620951
/// </summary>
public abstract class unclassified_Lygosoma : Lygosoma, Iunclassified_Lygosoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lygosoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620951;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lygosoma";
}
