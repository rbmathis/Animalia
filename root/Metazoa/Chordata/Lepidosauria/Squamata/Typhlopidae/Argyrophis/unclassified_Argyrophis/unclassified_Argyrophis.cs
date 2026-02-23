using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae.Argyrophis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae.Argyrophis.unclassified_Argyrophis;

/// <summary>
/// Abstract class for unclassified Argyrophis (no rank).
/// NCBI TaxId: 2626754
/// </summary>
public abstract class unclassified_Argyrophis : Argyrophis, Iunclassified_Argyrophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Argyrophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626754;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Argyrophis";
}
