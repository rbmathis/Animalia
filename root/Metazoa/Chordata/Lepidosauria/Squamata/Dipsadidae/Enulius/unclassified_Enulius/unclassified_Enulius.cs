using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Enulius;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Enulius.unclassified_Enulius;

/// <summary>
/// Abstract class for unclassified Enulius (no rank).
/// NCBI TaxId: 2636721
/// </summary>
public abstract class unclassified_Enulius : Enulius, Iunclassified_Enulius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Enulius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636721;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Enulius";
}
