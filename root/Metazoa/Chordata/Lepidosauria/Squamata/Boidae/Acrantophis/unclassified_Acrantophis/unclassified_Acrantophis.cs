using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Boidae.Acrantophis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Boidae.Acrantophis.unclassified_Acrantophis;

/// <summary>
/// Abstract class for unclassified Acrantophis (no rank).
/// NCBI TaxId: 2624307
/// </summary>
public abstract class unclassified_Acrantophis : Acrantophis, Iunclassified_Acrantophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Acrantophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624307;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Acrantophis";
}
