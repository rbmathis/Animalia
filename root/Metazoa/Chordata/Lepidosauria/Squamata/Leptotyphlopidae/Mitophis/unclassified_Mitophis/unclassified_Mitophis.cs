using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leptotyphlopidae.Mitophis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leptotyphlopidae.Mitophis.unclassified_Mitophis;

/// <summary>
/// Abstract class for unclassified Mitophis (no rank).
/// NCBI TaxId: 2640534
/// </summary>
public abstract class unclassified_Mitophis : Mitophis, Iunclassified_Mitophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mitophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640534;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mitophis";
}
