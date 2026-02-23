using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.unclassified_Squamata;

/// <summary>
/// Abstract class for unclassified Squamata (no rank).
/// NCBI TaxId: 728129
/// </summary>
public abstract class unclassified_Squamata : Squamata, Iunclassified_Squamata
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Squamata";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 728129;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Squamata";
}
