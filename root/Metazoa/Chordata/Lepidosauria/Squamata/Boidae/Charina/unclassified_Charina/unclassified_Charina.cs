using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Boidae.Charina;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Boidae.Charina.unclassified_Charina;

/// <summary>
/// Abstract class for unclassified Charina (no rank).
/// NCBI TaxId: 2878727
/// </summary>
public abstract class unclassified_Charina : Charina, Iunclassified_Charina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Charina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2878727;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Charina";
}
