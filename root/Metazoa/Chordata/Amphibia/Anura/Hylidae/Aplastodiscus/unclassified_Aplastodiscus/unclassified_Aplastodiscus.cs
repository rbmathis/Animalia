using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Aplastodiscus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Aplastodiscus.unclassified_Aplastodiscus;

/// <summary>
/// Abstract class for unclassified Aplastodiscus (no rank).
/// NCBI TaxId: 2633556
/// </summary>
public abstract class unclassified_Aplastodiscus : Aplastodiscus, Iunclassified_Aplastodiscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aplastodiscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633556;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aplastodiscus";
}
