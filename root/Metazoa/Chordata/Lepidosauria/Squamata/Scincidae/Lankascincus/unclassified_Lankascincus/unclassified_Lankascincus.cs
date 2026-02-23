using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Lankascincus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Lankascincus.unclassified_Lankascincus;

/// <summary>
/// Abstract class for unclassified Lankascincus (no rank).
/// NCBI TaxId: 3467913
/// </summary>
public abstract class unclassified_Lankascincus : Lankascincus, Iunclassified_Lankascincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lankascincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3467913;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lankascincus";
}
