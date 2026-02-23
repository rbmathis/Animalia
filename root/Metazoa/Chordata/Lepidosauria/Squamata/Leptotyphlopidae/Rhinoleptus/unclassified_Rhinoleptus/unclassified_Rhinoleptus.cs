using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leptotyphlopidae.Rhinoleptus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leptotyphlopidae.Rhinoleptus.unclassified_Rhinoleptus;

/// <summary>
/// Abstract class for unclassified Rhinoleptus (no rank).
/// NCBI TaxId: 2634725
/// </summary>
public abstract class unclassified_Rhinoleptus : Rhinoleptus, Iunclassified_Rhinoleptus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhinoleptus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634725;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhinoleptus";
}
