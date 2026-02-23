using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Calliophis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Calliophis.unclassified_Calliophis;

/// <summary>
/// Abstract class for unclassified Calliophis (no rank).
/// NCBI TaxId: 2649422
/// </summary>
public abstract class unclassified_Calliophis : Calliophis, Iunclassified_Calliophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Calliophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649422;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Calliophis";
}
